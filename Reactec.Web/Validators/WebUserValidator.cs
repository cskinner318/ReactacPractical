// <copyright file="WebUserValidator.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Web.Validators
{
    using System;
    using FluentValidation;
    using Reactec.Web.Models;

    /// <summary>
    /// Validator for the web user model.
    /// </summary>
    public class WebUserValidator : AbstractValidator<WebUser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebUserValidator"/> class.
        /// </summary>
        public WebUserValidator()
        {
            this.RuleFor(x => x.DateOfBirth)
                .NotNull().WithMessage("Date of birth is required")
                .LessThan(DateTime.Now.AddYears(-18))
                .WithMessage("User must be at least 18 years old");
            this.RuleFor(x => x.Name)
                .NotNull().WithMessage("Name is required")
                .NotEmpty().WithMessage("Name is required");
            this.RuleFor(x => x.EmailAddress)
                .NotEmpty().WithMessage("Email address is required")
                .NotNull().WithMessage("Email address is required")
                .EmailAddress().WithMessage("Valid email address is required");
        }
    }
}
