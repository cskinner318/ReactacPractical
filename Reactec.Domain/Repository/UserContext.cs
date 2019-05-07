// <copyright file="UserContext.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore;
    using Reactec.Domain.Repository.Models;

    /// <summary>
    /// Implementation of DbContext for user repository.
    /// </summary>
    public class UserContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserContext"/> class.
        /// </summary>
        /// <param name="dbContextOptions">db context options.</param>
        public UserContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }

        /// <summary>
        /// Gets or sets the Users db set.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Gets or sets the audit entries db set.
        /// </summary>
        public DbSet<LoginAudit> LoginAuditEntries { get; set; }
    }
}
