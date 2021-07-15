using Alfa.Entities;
using System;
using System.Collections.Generic;

namespace Alfa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Common, used or imported (c/u/i)?");
                char p = char.Parse(Console.ReadLine());
                Console.WriteLine("Product Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Product Price");
                double price = double.Parse(Console.ReadLine());

                if (p == 'c')
                {
                    string priceTag = (name+" $ "+price);
                    list.Add(new Product(name, price, priceTag));
                }
                else if (p == 'u')
                {
                    Console.WriteLine("Manufacture date(DD/MM/YYYY):");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    string priceTag = ("(used) $" + price + " (Manufacture date: " + manufactureDate + " )");
                    list.Add(new UsedProduct(name, price, manufactureDate, priceTag));
                }
                else if (p == 'i')
                {
                    Console.WriteLine("Custom fee price: ");
                    double CustomFee = double.Parse(Console.ReadLine());
                    double TotalPrice = price + CustomFee;
                    string priceTag = (name+" $"+ TotalPrice + " (Customs fee: $"+CustomFee+")");
                    list.Add(new ImportedProduct(priceTag));
                }
                else
                {
                    Console.WriteLine("Erro em resgistrar um dos produtos");
                }

                foreach (Product emp in list)
                {
                    Console.WriteLine(emp.priceTag);
                }

            }

        }
    }
}

