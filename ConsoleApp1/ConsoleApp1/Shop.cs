using System;
using System.Collections.Generic;

namespace ShopApp
{
    public class Shop
    {
        
        public List<Product> ProductsStock = new List<Product>();

        public void AddProduct(string productName,UInt32 stockNumber)
        {
          var product = new Product(productName, stockNumber);
          List<Product> products = new List<Product>();
          products.Add(product);
          

          ProductsStock.AddP(products);
          
        

        }

        public void RemoveProduct(string productName, UInt32 stockNumber)
        {
            var product = ProductsStock.Find(p => p.ProductName == productName);

            if (product == null)
            {
                Console.WriteLine("Item not found");
                return;
            }

            if (product.StockNumber > stockNumber)
            {
                product.StockNumber -= stockNumber;
                return;
            }

            if (product.StockNumber < stockNumber)
            {
                Console.WriteLine("We dont have that capacity");
                return;
            }

            if (product.StockNumber == stockNumber)
            {
                ProductsStock.Remove(product);
                return;
            }
        
            ListOfItems();
        }

        private void ListOfItems()
        {
            foreach (Product i in ProductsStock)
            {
                Console.WriteLine(i.ProductName + " " + i.StockNumber);
            }
            Console.WriteLine();
        }
    }
}