using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Bulky.Models;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IProductRepository<T> : IRepository<T> where T : class
    {
        bool Any(Expression<Func<Product, bool>> predicate);
        void Update(Models.Product obj);
    }
}
