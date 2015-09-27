using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Portfolio.Core.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        void Create(TEntity entity);
        void Edit(TEntity entity);
        void Delete(string entityID);
        IEnumerable<TEntity> GetPortfolioItems();
        TEntity FindById(string entityID);
    }
}
