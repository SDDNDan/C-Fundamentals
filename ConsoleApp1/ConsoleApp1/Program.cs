using System;
namespace ShopApp
{
    class Program
    {
        public static void Main()
        {
            Shop shop = new Shop();
            while (true)
            {
                Console.WriteLine("Add or Remove or Exit?");
                var result = Console.ReadLine();
                if (result != null && result.Equals("Add"))
                {
                    Console.WriteLine("Tell product Name");
                    var product = Console.ReadLine();
                    Console.WriteLine("Tell product Stock");
                    UInt32 stock;
                    try
                    {
                         stock = Convert.ToUInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("DC AI PUS NEGATIV BOSSS");
                        break;
                    }

                    shop.AddProduct(product, stock);
                }
                else if (result != null && result.Equals("Remove"))
                {
                    Console.WriteLine("Tell product Name");
                    var product = Console.ReadLine();
                    Console.WriteLine("Tell product Stock");
                    UInt32 stock;
                    try
                    {
                         stock = Convert.ToUInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("DC AI PUS NEGATIV BOSSS");
                        break;
                    }
                    shop.RemoveProduct(product, stock);

                }
                else if (result != null && result.Equals("Exit"))
                {
                    break;

                }
                else
                {
                    Console.WriteLine("Command Not Found");
                }
            }
        }
    }
}
