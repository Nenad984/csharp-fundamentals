﻿using System;

using static System.Console;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using MyLibraary.Share;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using static System.Console;


namespace WorkingWithEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryingCategories();
        }

        static void QueryingCategories()
        {
            using (var db = new Northwind())
            {
                WriteLine("Categories and how many products they have:");

                IQueryable<Category> cats = db.Categories.Include(c => c.Products);

                foreach (Category c in cats)
                {
                    WriteLine($"{c.CategoryName} has {c.Products.Count} products.");
                }
            }
        }
    }
}
