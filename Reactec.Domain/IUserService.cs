// <copyright file="IUserService.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain
{
    using System;
    using System.Collections.Generic;
    using Reactec.Domain.DataStore.Models;
    using Reactec.Domain.QueryResults;

    /// <summary>
    /// Interface for carrying out user requests.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Register a login event.
        /// </summary>
        /// <param name="name">The user's name.</param>
        /// <param name="email">The user's email address.</param>
        /// <param name="dateOfBirth">The user's date of birth.</param>
        /// <returns>Returns the user id</returns>
        UserQueryResult RegisterLogin(string name, string email, DateTime dateOfBirth);

        /// <summary>
        /// Gets the login audit history for a given user.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns>An IEnumerable of AuditHistory.</returns>
        IEnumerable<LoginAuditQueryResult> AuditHistory(int userId);
    }
}
