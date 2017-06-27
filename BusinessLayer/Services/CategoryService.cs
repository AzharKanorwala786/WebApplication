using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Interface;
using DTO;
using RepositoryLayer.Interface;

namespace BusinessLayer.Services
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        private IUnitOfWork UnitofWork;
        public CategoryService(IUnitOfWork UnitofWork) : base(UnitofWork)
        {
            this.UnitofWork = UnitofWork;
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return GetAll();
        }

        public Category GetByCategoryId(object Id)
        {
            return GetById(Id);
        }

        public void SaveChanges()
        {
            Save();
        }
    }
}
