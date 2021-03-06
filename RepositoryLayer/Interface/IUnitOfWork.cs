﻿namespace DataAccess
{
    using Entities;
    using System.Collections.Generic;

    public interface IUnitOfWork
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<Contracts.Product> GetAll();

        /// <summary>
        /// 
        /// </summary>
        void Save();
    }
}
