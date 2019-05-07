// <copyright file="IDataRepository.cs" company="Reactec Practical">
// Copyright (c) Reactec Practical. All rights reserved.
// </copyright>

namespace Reactec.Domain.Repository
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for interacting with the data store.
    /// </summary>
    /// <typeparam name="TEntity">The Data Type.</typeparam>
    public interface IDataRepository<TEntity>
    {
        /// <summary>
        /// Get all data items.
        /// </summary>
        /// <returns>An IEnumerable fo the data items.</returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Returns a data item by it's ID.
        /// </summary>
        /// <param name="id">The data ID.</param>
        /// <returns>The Data Type.</returns>
        TEntity Get(int id);

        /// <summary>
        /// Add a new data item to the store.
        /// </summary>
        /// <param name="entity">The Data Item.</param>
        void Add(TEntity entity);

        /// <summary>
        /// Update a data item.
        /// </summary>
        /// <param name="dbEntity">The entity in the data store.</param>
        /// <param name="entity">The update entity.</param>
        void Update(TEntity dbEntity, TEntity entity);
    }
}
