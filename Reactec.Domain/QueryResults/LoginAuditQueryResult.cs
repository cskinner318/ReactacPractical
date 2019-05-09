// <copyright file="LoginAudit.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain.QueryResults
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Login Audit Poco.
    /// </summary>
    public class LoginAuditQueryResult
    {
        /// <summary>
        /// Gets or sets the User.
        /// </summary>
        public UserQueryResult User { get; set; }

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
