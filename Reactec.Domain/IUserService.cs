// <copyright file="IUserService.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain
{
    using Reactec.Domain.DataStore.Models;
    using System;
    using System.Collections.Generic;

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
        User RegisterLogin(string name, string email, DateTime dateOfBirth);

        IEnumerable<LoginAudit>
    }
}
