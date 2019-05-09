// <copyright file="AuditHistory.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Reactec.Domain.Enums;
    using Reactec.Domain.QueryResults;

    /// <summary>
    /// Audit history view model.
    /// </summary>
    public class AuditHistory
    {
        /// <summary>
        /// Gets or sets the search term.
        /// </summary>
        public string SearchTerm { get; set; }

        /// <summary>
        /// Gets or sets the sort method.
        /// </summary>
        public SortMethod SortMethod { get; set; }

        /// <summary>
        /// Gets or sets the login audits collection.
        /// </summary>
        public IEnumerable<LoginAuditQueryResult> LoginAudits { get; set; }
    }
}
