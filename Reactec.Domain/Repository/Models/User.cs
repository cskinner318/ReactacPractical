// <copyright file="User.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Reactec.Domain.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// DTO for users.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the unique user Id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        /// <summary>
        /// Gets or sets a list of Login Audits.
        /// </summary>
        public ICollection<LoginAudit> LoginAudits { get; set; }
    }
}
