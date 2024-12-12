using InventoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryApp.Services
{
    public class InventoryManagement
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(int id, string name, int quantity, string location)
        {
            /* verificamos input parameters*/
            if (quantity < 0)
            {
                Console.WriteLine("Error: Quantity cannot be negative.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Error: Name cannot be empty.");
                return;
            }

            var existingProduct = null;
            foreach(var p in products)
            {
                if(p.Id == id)
                {
                    existingProduct = p;
                    break;
                }
            }
            if (existingProduct != null)
            {
                existingProduct.Quantity += quantity;
                Console.WriteLine($"Updated quantity for product with Id: {id}");
            }
            else
            {
                products.Add(new Product { Id = id, Name = name, Quantity = quantity, Location = location });
                Console.WriteLine($"Added new product with Id: {id}");
            }
        }

        public void UpdateProductLocation(int id, string newLocation)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            /*foreach(var p in product)
            {
                if(p.Id == id)
                {
                    p.Location = newLocation;
                }
            }*/
            if (product != null)
            {
                product.Location = newLocation;
                Console.WriteLine($"Updated location for product with Id: {id}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void RemoveProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine($"Removed product with Id: {id}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void FindProduct(string name)
        {
            var foundProducts = products.Where(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
            if (foundProducts.Any())
            {
                foreach (var product in foundProducts)
                {
                    Console.WriteLine(product);
                }
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void ListAllProducts()
        {
            if (!products.Any())
            {
                Console.WriteLine("No products in inventory.");
                return;
            }

            var sortedProducts = products.OrderBy(p => p.Name).ToList();
            foreach (var product in sortedProducts)
            {
                Console.WriteLine(product);
            }
        }
    }
}
