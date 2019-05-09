// <copyright file="IUserService.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain
{
    using System;
    using System.Collections.Generic;
    using Reactec.Domain.DataStore.Models;
    using Reactec.Domain.Enums;
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
        /// Gets the full login audit history.
        /// </summary>
        /// <returns>An IEnumerable of AuditHistory.</returns>
        IEnumerable<LoginAuditQueryResult> AuditHistory();

        /// <summary>
        /// Gets the login audit history with search and filter parameters.
        /// </summary>
        /// <param name="searchParam">Any search parameters.</param>
        /// <param name="sortMethod">The sort method.</param>
        /// <returns>An IEnumerable of AuditHistory.</returns>
        IEnumerable<LoginAuditQueryResult> AuditHistory(string searchParam, SortMethod sortMethod);
    }
}
