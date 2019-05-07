// <copyright file="ServiceCollectionExtensions.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Reactec.Domain.DataStore;
    using Reactec.Domain.DataStore.Models;
    using Reactec.Domain.Repository;

    /// <summary>
    /// DI extension for .Net Core.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the repository services.
        /// </summary>
        /// <param name="services">DI.</param>
        /// <param name="connectionString">Connection string to the db.</param>
        public static void AddRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<UserContext>(opts => opts.UseSqlServer(connectionString));
            services.AddScoped<IDataRepository<User>, UserRepository>();
            services.AddScoped<IDataRepository<LoginAudit>, AuditRepository>();
        }
    }
}
