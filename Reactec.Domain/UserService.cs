﻿// <copyright file="UserService.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain
{
    using System;
    using System.Linq;
    using Reactec.Domain.DataStore.Models;
    using Reactec.Domain.Repository;

    /// <summary>
    /// Implementation of the IUserService.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IDataRepository<User> userRepository;
        private readonly IDataRepository<LoginAudit> auditRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class.
        /// </summary>
        /// <param name="userRepository">Repository for user data.</param>
        /// <param name="auditRepository">Repository for login audit data.</param>
        public UserService(IDataRepository<User> userRepository, IDataRepository<LoginAudit> auditRepository)
        {
            this.userRepository = userRepository;
            this.auditRepository = auditRepository;
        }

        /// <inheritdoc/>
        public void RegisterLogin(string name, string email, DateTime dateOfBirth)
        {
            // Check that the user exists
            var existingUser = this.userRepository.GetAll().Where(x => x.Name == name && x.Email == email).FirstOrDefault();
            if (existingUser != null)
            {
                this.auditRepository.Add(new LoginAudit { AuditTime = DateTime.Now, User = existingUser });
            }
            else
            {
                var newUser = new User { Name = name, Email = email, DateOfBirth = dateOfBirth, Locked = false };
                this.userRepository.Add(newUser);
                this.auditRepository.Add(new LoginAudit { AuditTime = DateTime.Now, User = newUser });
            }
        }
    }
}