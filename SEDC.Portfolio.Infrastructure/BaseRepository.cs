using SEDC.Portfolio.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEDC.Portfolio.Core.Entities;
using System.Data.Entity;

namespace SEDC.Portfolio.Infrastructure
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected PortfolioDbContext _context;

        public BaseRepository(PortfolioDbContext context)
        {
            _context = context;
        }

        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(string entityID)
        {
            TEntity T = _context.Set<TEntity>().Find(entityID);
            _context.Set<TEntity>().Remove(T);
            _context.SaveChanges();
        }

        public void Edit(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public TEntity FindById(string entityID)
        {
            return _context.Set<TEntity>().Find(entityID);
        }

        public IEnumerable<TEntity> GetPortfolioItems()
        {
            throw new NotImplementedException();
        }
    }
}
