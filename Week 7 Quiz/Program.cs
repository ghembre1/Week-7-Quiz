using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7_Quiz
{
    internal class Program
    {
        public class Product
        {
            public string ProductID { get; set; }
            public string ProductName { get; set; }
            public double Price { get; set; }

            public Product()
            {
                ProductID = ProductID;
                ProductName = ProductName;
                Price = Price;
            }
            class ShoppingCart
            {
                private List<Product> products;

                public ShoppingCart()
                {
                    products = new List<Product>();
                }

                public void AddProduct(Product product)
                {
                    products.Add(product);
                    Console.WriteLine($"Added {product.ProductName} to the cart.");
                }

                public void RemoveProduct(string productId)
                {
                    Product productToRemove = products.Find(product => product.ProductID == productId);
                    if (productToRemove != null)
                    {
                        products.Remove(productToRemove);
                        Console.WriteLine($"Removed {productToRemove.ProductName} from the cart.");
                    }
                }
                public void CalculateTotalPrice()
                {

                }
                static void Main(string[] args)
                {
                    Console.WriteLine("What are you wanting to do");
                    Console.WriteLine("1. Add a product");
                    Console.WriteLine("2. Remove a product");
                    Console.WriteLine("3. Calculate the cost");
                    int input = Convert.ToInt32(Console.ReadLine());

                    switch (input)
                    {
                        case 1:
                            AddProduct();
                            break;

                        case 2:
                            RemoveProduct();
                            break;

                        case 3:
                            CalculateTotalPrice();
                            break;
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}
