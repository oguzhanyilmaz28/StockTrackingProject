using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StockTrackingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager products = new ProductManager();
            while (true)
            {
                Console.Clear();
                string process;
                Console.WriteLine("Choose one of the following actions:");
                Console.WriteLine("1-Printing products to screen");
                Console.WriteLine("2-Add product");
                Console.WriteLine("3-Product extraction");
                Console.WriteLine("4-Product updating");
                Console.WriteLine("5-Exit");
                Console.Write("Your choice: ");
                process = Console.ReadLine();
                Console.Clear();
                switch (process)
                {
                    case "1":
                        if (products.ProductQuantity() == 0)
                        {
                            Console.WriteLine("There is no product.Please add the product first.");
                        }
                        else
                        {
                            products.Print();
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter the product name:");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter the product type:");
                        string Type = Console.ReadLine();
                        Console.WriteLine("Enter the product quantity:");
                        int Quantity = Convert.ToInt32(Console.ReadLine());
                        products.Add(new Product(Name, Type, Quantity));
                        Console.WriteLine("The product has been successfully added");
                        continue;

                    case "3":
                        if (products.ProductQuantity() == 0)
                        {
                            Console.WriteLine("There is no product.Please add the product first.");
                        }
                        else
                        {
                            products.Print();
                            Console.WriteLine("Enter the number of the product you want to delete. ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            products.TakeOutIndex(index);
                            Console.WriteLine("The product has been successfully extracted.");
                        }
                        Thread.Sleep(1500);
                        continue;

                    case "4":
                        if (products.ProductQuantity() == 0)
                        {
                            Console.WriteLine("There is no product.Please add the product first.");
                        }
                        else
                        {
                            products.Print();
                            Console.WriteLine("Enter the number of the product you want to update .");
                            int i = Convert.ToInt32(Console.ReadLine());
                            Product product = products.GetByIndex(i);
                            Console.WriteLine("Enter the  product new quantity:");
                            int x = Convert.ToInt32(Console.ReadLine());
                            products.Update(product.Id, x);
                            Console.WriteLine("The product has been successfully updated.");
                        }
                        Thread.Sleep(1500);
                        continue;

                    case "5":
                        Console.WriteLine("Logged out.");
                        Thread.Sleep(1500);
                        Environment.Exit(0);
                        break;
                }
                    

            }
            Thread.Sleep(1500);
        }

    }
}

