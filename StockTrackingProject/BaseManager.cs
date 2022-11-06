using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingProject
{
    public class BaseManager<T> : IBaseManager<T> where T : IEntity
    {
        protected List<T> entities;
        public BaseManager()
        {
            entities = new List<T>();
        }
        public void Add(T entity)
        {
            entities.Add(entity);
        }
        public void Remove(Guid id)
        {
            T entity = null;
            foreach (T a in entities)
            {
                if (a.Id == id)
                {
                    entity = a;
                }
            }
            entities.Remove(entity);
        }
        public int Count()
        {
            return entities.Count();
        }
        public virtual void ShowAll()
        {

            for (int i = 0; i < entities.Count; i++)
            {
                Console.WriteLine(i + ". - " + entities[i].Id + " " + entities[i].ToString());
            }
        }
        public virtual void Update(T entity)
        {
            T item = null;
            foreach (T a in entities)
            {
                if (a.Id == entity.Id)
                {
                    item = entity;
                }
            }
        }

        public T GetById(Guid id)
        {
            return entities.SingleOrDefault(x => x.Id == id);
        }

        public T GetByIndex(int index)
        {
            return entities[index];
        }

        public void RemoveIndex(int index)
        {
            entities.RemoveAt(index);
        }

    }
}
