using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using MyLibrary.Share;
using Microsoft.EntityFrameworkCore.Infrastructure; 
using Microsoft.Extensions.DependencyInjection; 
using Microsoft.Extensions.Logging;

using static System.Console;


namespace WorkingWithEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
           // QueryingProducts();
             QueryingCategories();
        }

        static void QueryingCategories()
        {
            using (var db = new Northwind())
            {
                var loggerFactory = db.GetService<ILoggerFactory>(); 
                
                loggerFactory.AddProvider(new ConsoleLoggerProvider());
                
                WriteLine("Categories and how many products they have:");

                IQueryable<Category> cats = db.Categories.Include(c => c.Products);

                foreach (Category c in cats)
                {
                    WriteLine($"{c.CategoryName} has {c.Products.Count} products.");
                }
            }
        }

        static void QueryingProducts()
        {

            using (var db = new Northwind())
            {
                var loggerFactory = db.GetService<ILoggerFactory>(); 
                
                loggerFactory.AddProvider(new ConsoleLoggerProvider());
                
                WriteLine("Products that cost more than a price, highest at top.");
                
                string input; 
                
                int price; 
                
                do
                {
                   
                    Write("Enter a product price: "); 
                    input = ReadLine();
                
                } while (!int.TryParse(input, out price));
                
                IQueryable<Product> prods = db.Products.Where(product => product.Cost > price).OrderByDescending(product => product.Cost);

                foreach (Product item in prods)
                {
                    WriteLine("{0}: {1} costs {2:$#,##0.00} and has {3} in stock.", item.ProductID, item.ProductName, item.Cost, item.Stock);
                }
            }
        }
    }
}
