using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BusinessLayer.Interface
{
  public interface ICategoryService : IGenericService<Category>
    {
        IEnumerable<Category> GetAllCategory();
        Category GetByCategoryId(object Id);
        void SaveChanges();
    }
}
