using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingProject
{
    internal class ProductManager
    {
        private List<Product> Products;
        public ProductManager()
        {
            Products = new List<Product>();
        }
        public void Add(Product product)
        {
            Products.Add(product);
        }
        public void TakeOut(Guid id)
        {
            Product product = null;
            foreach (Product a in Products)
            {
                if (a.Id == id)
                {
                    product = a;
                }
            }
            Products.Remove(product);
        }
        public int ProductQuantity()
        {
            return Products.Count();
        }
        public void Print()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine("number " + (i + 1) + " product name :{0} , product type : {1} , product quantity : {2}", Products[i].Name, Products[i].Type, Products[i].Quantity);
            }
        }
        public void Update(Guid id, int quantity)
        {
            Product product = null;
            foreach (Product a in Products)
            {
                if (a.Id == id)
                {
                    product = a;
                    product.Quantity = quantity;
                }
            }
        }

        public void TakeOutIndex(int index)
        {
            Product product = Products[index - 1];
            Products.Remove(product);
        }
        public Product GetByIndex(int i)
        {
            return Products[i - 1];
        }
    }
}
