using ReceiptManager.Main.Models;
using System.Collections.Generic;
using System.Linq;

namespace ReceiptManager.Services.Interfaces
{
    public interface IDbService
    {
        ServiceResults Create<T>(T entity) where T : Entity;
        ServiceResults Delete<T>(T entity) where T : Entity;
        ServiceResults Update<T>(T entity) where T : Entity;
        List<T> GetAll<T>() where T : Entity;
        T GetById<T>(int id) where T : Entity;
        IQueryable<T> Query<T>() where T : Entity;
    }
}
