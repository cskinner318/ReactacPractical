﻿// <copyright file="HomeController.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Reactec.Domain;
    using Reactec.Web.Models;

    /// <summary>
    /// Home controller.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly IUserService userService;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="userService">The user service.</param>
        public HomeController(IUserService userService)
        {
            this.userService = userService;
        }

        /// <summary>
        /// Get Index.
        /// </summary>
        /// <returns>IActionResult.</returns>
        [HttpGet]
        public IActionResult Index()
        {
            return this.View("Index");
        }

        /// <summary>
        /// Post Index.
        /// </summary>
        /// <param name="webUser">The web user model.</param>
        /// <returns>IActionResult.</returns>
        [HttpPost]
        public IActionResult Index(WebUser webUser)
        {
            var user = this.userService.RegisterLogin(webUser.Name, webUser.EmailAddress, webUser.DateOfBirth);

            if (user.Locked)
            {
                webUser.Locked = true;
                return this.View("Index", webUser);
            }

            if (!this.ModelState.IsValid)
            {
                return this.View("Index", webUser);
            }

            return this.RedirectToAction("AuditHistory");
        }

        /// <summary>
        /// Get Audit History.
        /// </summary>
        /// <returns>IActionResult.</returns>
        [HttpGet]
        public IActionResult AuditHistory()
        {
            var history = this.userService.AuditHistory();
            return this.View("AuditHistory", new AuditHistory { LoginAudits = history });
        }

        /// <summary>
        /// Audit History Search.
        /// </summary>
        /// <param name="auditHistory">The audit history view model.</param>
        /// <returns>IActionResult.</returns>
        [HttpPost]
        public IActionResult AuditHistory(AuditHistory auditHistory)
        {
            var history = this.userService.AuditHistory(auditHistory.SearchTerm, auditHistory.SortMethod);
            auditHistory.LoginAudits = history;
            return this.View("AuditHistory", auditHistory);
        }
    }
}
