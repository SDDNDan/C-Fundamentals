using System;

namespace ShopApp
{
    public class Product
    {
        public string ProductName;
        public UInt32 StockNumber;
        public Product(string productName, UInt32 stockNumber)
        {
            ProductName = productName;
            StockNumber = stockNumber;
        }
    }
}
