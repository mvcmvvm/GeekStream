﻿using System.Collections.Generic;
using System.Threading.Tasks;
using GeekStream.Core.Entities;

namespace GeekStream.Core.Interfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetAll();
        public Task SaveAsync(Category category);
        public Category GetById(int id);
        public Task Update(Category category);
        public Task Delete(Category category);
    }
}