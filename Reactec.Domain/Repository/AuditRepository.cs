// <copyright file="AuditRepository.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Reactec.Domain.DataStore;
    using Reactec.Domain.DataStore.Models;

    /// <summary>
    /// Implementation of the IDataRepository for Login Audits.
    /// </summary>
    public class AuditRepository : IDataRepository<LoginAudit>
    {
        private readonly UserContext userContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditRepository"/> class.
        /// </summary>
        /// <param name="userContext">The data store context.</param>
        public AuditRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }

        /// <inheritdoc/>
        public void Add(LoginAudit entity)
        {
            this.userContext.Add(entity);
            this.userContext.SaveChanges();
        }

        /// <inheritdoc/>
        public LoginAudit Get(int id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public IEnumerable<LoginAudit> GetAll()
        {
            return this.userContext.LoginAuditEntries.Include(x => x.User).AsEnumerable();
        }

        /// <inheritdoc/>
        public void Update(LoginAudit dbEntity, LoginAudit entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
