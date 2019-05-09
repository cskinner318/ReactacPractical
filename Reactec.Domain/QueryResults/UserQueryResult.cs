// <copyright file="User.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain.QueryResults
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// User POCO.
    /// </summary>
    public class UserQueryResult
    {
        /// <summary>
        /// Gets or sets the unique user Id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the user's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the user's email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the user's date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is locked.
        /// </summary>
        public bool Locked { get; set; }
    }
}
