using ReceiptManager.Data;
using ReceiptManager.Main.Interfaces;
using ReceiptManager.Main.Models;
using System.Collections.Generic;
using System.Linq;

namespace ReceiptManager.Services.Services
{
    public class EntityService<T> : DbService, IEntityService<T> where T : Entity
    {
        public EntityService(ReceiptDbContext context) : base(context)
        {
        }

        public ServiceResults Create(T entity)
        {
            return Create<T>(entity);
        }

        public ServiceResults Delete(T entity)
        {
            return Delete<T>(entity);
        }
       
        public ServiceResults Update(T entity)
        {
            return Update<T>(entity);
        }

        public List<T> GetAll()
        {
            return GetAll<T>();
        }

        public T GetById(int id)
        {
            return GetById<T>(id);
        }

        public IQueryable<T> Query()
        {
            return Query<T>();
        }
    }
}
