using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingProject
{
    public interface IBaseManager<T>
    {
        void Add(T entity);
        void Remove(Guid id);
        int Count();
        void ShowAll();
        void Update(T entity);
        T GetById(Guid id);
        T GetByIndex(int index);
        void RemoveIndex(int index);
    }
}
