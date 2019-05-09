// <copyright file="LoginAudit.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain.DataStore.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// DTO for Login Audit.
    /// </summary>
    public class LoginAudit
    {
        /// <summary>
        /// Gets or sets the unique audit Id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoginAuditId { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the login audit time.
        /// </summary>
        public DateTime AuditTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user met the age criteria at the point of logon.
        /// </summary>
        public bool MeetsAgeCriteria { get; set; }
    }
}
