// <copyright file="ServiceCollectionExtensions.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AutoMapper;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
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
            services.AddScoped<IUserService, UserService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        /// <summary>
        /// Configures the repository services.
        /// </summary>
        /// <param name="app">Application builder.</param>
        public static void ConfigureRepository(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<UserContext>();
                context.Database.EnsureCreated();
            }
        }
    }
}
