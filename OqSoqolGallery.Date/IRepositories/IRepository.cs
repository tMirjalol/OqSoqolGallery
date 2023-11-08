﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OqSoqolGallery.Date.IRepositories
{
    public interface IRepository<TEntity>
    {
        public Task<TEntity> InsertAsync(TEntity entity);
        public Task<TEntity> UpdateAsync(TEntity entity);
        public Task<bool> DeleteAsync(long id);
        public Task<TEntity> SelectByIdAsync(long id);
        public IQueryable<TEntity> SelectAll();
    }
}
