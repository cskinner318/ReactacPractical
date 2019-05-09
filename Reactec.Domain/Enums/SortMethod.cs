// <copyright file="SortMethod.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain.Enums
{
    /// <summary>
    /// Sort method applied to audit history.
    /// </summary>
    public enum SortMethod
    {
        /// <summary>
        /// Sort by name ascending.
        /// </summary>
        NameAscending,

        /// <summary>
        /// Sort by name descending.
        /// </summary>
        NameDescending,

        /// <summary>
        /// Sort by email ascending.
        /// </summary>
        EmailAscending,

        /// <summary>
        /// Sort by name descending.
        /// </summary>
        EmailDescending,

        /// <summary>
        /// Sort by date of birth ascending.
        /// </summary>
        DateOfBirthAscending,

        /// <summary>
        /// Sort by date of birth descending.
        /// </summary>
        DateOfBirthDescending,

        /// <summary>
        /// Sort by login time ascending.
        /// </summary>
        LoginTimeAscending,

        /// <summary>
        /// Sort by login time descending.
        /// </summary>
        LoginTimeDescending,
    }
}
