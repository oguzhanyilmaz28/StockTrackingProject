using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingProject
{
    public class Product : BaseEntity
    {
        private string name;
        private string type;
        private int quantity;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
        public Product(String Name, String Type, int Quantity)
        {
            this.Name = Name;
            this.Quantity = Quantity;
            this.Type = Type;
        }

        public override string ToString()
        {
            return name + " " + quantity + " " + type;
        }
    }
}
