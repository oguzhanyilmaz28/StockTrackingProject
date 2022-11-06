using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingProject
{
    public abstract class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            id = Guid.NewGuid();
        }
        private Guid id;
        public Guid Id
        {
            get
            {
                return id;
            }
        }
    }
}
