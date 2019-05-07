﻿// <copyright file="LoginAudit.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Reactec.Domain.Repository.Models
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
    }
}
