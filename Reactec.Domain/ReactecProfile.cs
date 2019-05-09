// <copyright file="ReactecProfile.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain
{
    using AutoMapper;
    using Reactec.Domain.DataStore.Models;
    using Reactec.Domain.QueryResults;

    /// <summary>
    /// Automapper class for Reactec Domain.
    /// </summary>
    public class ReactecProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReactecProfile"/> class.
        /// </summary>
        public ReactecProfile()
        {
            this.CreateMap<User, UserQueryResult>();
            this.CreateMap<LoginAudit, LoginAuditQueryResult>();
        }
    }
}
