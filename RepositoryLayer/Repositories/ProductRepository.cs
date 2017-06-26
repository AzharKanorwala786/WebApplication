using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Contexts;
using DTO;
using RepositoryLayer.Interface;
using System.Data.Entity;

namespace RepositoryLayer.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        private Context dbcontext;
        private DbSet<Product> dbset;

        public ProductRepository(Context dbcontext) : base(dbcontext)
        {
            this.dbcontext = dbcontext;
            this.dbset = dbcontext.Set<Product>();
        }

        public IEnumerable<Product> GetAll()
        {
            var products = dbset.Include("Category").AsEnumerable();
            return products;
        }

    }
}
