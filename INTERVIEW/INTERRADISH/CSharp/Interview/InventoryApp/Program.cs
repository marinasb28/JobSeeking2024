using InventoryApp.Models;
using InventoryApp.Services;
using System;

namespace InventoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new InventoryManagement();

            inventory.AddProduct(101, "Laptop", 50, "A1");
            inventory.AddProduct(102, "Mouse", 200, "B2");
            inventory.AddProduct(101, "Laptop", 10, "A1"); // Duplicate ID updates quantity

            Console.WriteLine("\n--- All Products ---");
            inventory.ListAllProducts();

            inventory.UpdateProductLocation(102, "C3");

            Console.WriteLine("\n--- Find Product by Name: 'Laptop' ---");
            inventory.FindProduct("Laptop");

            inventory.RemoveProduct(101);

            Console.WriteLine("\n--- All Products After Removal ---");
            inventory.ListAllProducts();

            Console.WriteLine("Program completed.");
        }
    }
}
