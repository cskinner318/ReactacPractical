// <copyright file="UserRepository.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using Reactec.Domain.DataStore;
    using Reactec.Domain.DataStore.Models;

    /// <summary>
    /// Implementation of the IDataRepository for Users.
    /// </summary>
    public class UserRepository : IDataRepository<User>
    {
        private readonly UserContext userContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="userContext">The data store context.</param>
        public UserRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }

        /// <inheritdoc/>
        public void Add(User entity)
        {
            this.userContext.Users.Add(entity);
            this.userContext.SaveChanges();
        }

        /// <inheritdoc/>
        public User Get(int id)
        {
            return this.userContext.Users.FirstOrDefault(x => x.UserId == id);
        }

        /// <inheritdoc/>
        public IEnumerable<User> GetAll()
        {
            return this.userContext.Users.AsEnumerable();
        }

        /// <inheritdoc/>
        public void Update(User dbEntity, User entity)
        {
            dbEntity.Name = entity.Name;
            dbEntity.Locked = entity.Locked;
            dbEntity.Email = entity.Email;
            dbEntity.DateOfBirth = entity.DateOfBirth;

            this.userContext.SaveChanges();
        }
    }
}
