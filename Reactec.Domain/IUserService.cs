// <copyright file="IUserService.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain
{
    using System;

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
        void RegisterLogin(string name, string email, DateTime dateOfBirth);

        /// <summary>
        /// Check if a user is locked.
        /// </summary>
        /// <param name="name">The user's name.</param>
        /// <param name="email">The user's email address.</param>
        /// <returns>A bool indiciating if the user is locked.</returns>
        bool CheckUserIsLocked(string name, string email);
    }
}
