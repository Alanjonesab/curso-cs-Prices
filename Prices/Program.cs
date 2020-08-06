using Prices.Entities;
using System;
using System.Collections.Generic;

namespace Prices
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product {0}# data: ", i);
                Console.Write("Common, used or imported (c/u/i): ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: $ ");
                    double price = double.Parse(Console.ReadLine());
                    products.Add(new Product(name, price));

                }
                else if(ch == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: $ ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Manufacture Date (dd/MM/yyyy): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, date));
                }

                else 
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: $ ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Customs Fee: $ ");
                    double customsFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customsFee));
                }       
                
            }

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}
