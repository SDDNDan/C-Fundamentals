using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public static class AddProduct
    {
        public static void AddP(this List<Product> officialProducts, List<Product> products)
        {
            foreach (Product i in products)
            {
                var product = officialProducts.Find(p => p.ProductName == i.ProductName);
                if (product == null)
                {
                    officialProducts.Add(i);
                }
                else
                {
                    product.StockNumber += i.StockNumber;
                }
            }

            Console.WriteLine("Itemele sunt:");
            foreach (Product i in officialProducts)
            {
                Console.WriteLine(i.ProductName + " " + i.StockNumber);
            }
            Console.WriteLine("End");
            Console.WriteLine();
        }
    }
}
