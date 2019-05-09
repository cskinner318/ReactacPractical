// <copyright file="UserService.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Reactec.Domain.DataStore.Models;
    using Reactec.Domain.QueryResults;
    using Reactec.Domain.Repository;

    /// <summary>
    /// Implementation of the IUserService.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IDataRepository<User> userRepository;
        private readonly IDataRepository<LoginAudit> auditRepository;
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class.
        /// </summary>
        /// <param name="userRepository">Repository for user data.</param>
        /// <param name="auditRepository">Repository for login audit data.</param>
        /// <param name="mapper">Automapper profile.</param>
        public UserService(IDataRepository<User> userRepository, IDataRepository<LoginAudit> auditRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.auditRepository = auditRepository;
            this.mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IEnumerable<LoginAuditQueryResult> AuditHistory(int userId)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public UserQueryResult RegisterLogin(string name, string email, DateTime dateOfBirth)
        {
            // the 18 years should be in config really
            bool userOver18 = dateOfBirth <= DateTime.Now.AddYears(-18);

            // Check that the user exists
            var existingUser = this.userRepository.GetAll().Where(x => x.Name == name && x.Email == email).FirstOrDefault();

            // if so just record the audit
            if (existingUser != null)
            {
                this.auditRepository.Add(new LoginAudit { AuditTime = DateTime.Now, User = existingUser, MeetsAgeCriteria = userOver18 });
                existingUser.Locked = this.CheckAndLockUser(existingUser);

                return this.mapper.Map<UserQueryResult>(existingUser);
            }
            else
            {
                // otherwise create a new user
                var newUser = new User { Name = name, Email = email, DateOfBirth = dateOfBirth, Locked = false };
                this.userRepository.Add(newUser);
                this.auditRepository.Add(new LoginAudit { AuditTime = DateTime.Now, User = newUser, MeetsAgeCriteria = userOver18 });
                return this.mapper.Map<UserQueryResult>(newUser);
            }
        }

        private bool CheckAndLockUser(User user)
        {
            if (user.Locked)
            {
                return true;
            }

            var failedLogins = this.userRepository.Get(user.UserId).LoginAudits.Where(x => x.AuditTime >= DateTime.Now.AddHours(-1) && !x.MeetsAgeCriteria);
            if (failedLogins.Any() && failedLogins.Count() >= 3)
            {
                user.Locked = true;
                this.userRepository.Update(this.userRepository.Get(user.UserId), user);
                return true;
            }

            return false;
        }
    }
}
