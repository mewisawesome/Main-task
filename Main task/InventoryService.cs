using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_task
{
    internal static class InventoryService
    {
        public static List<Product> LoadFromCSV(string filePath)
        {
            List<Product> products = new List<Product>();
            if (!File.Exists(filePath)) return products;
            
            var lines = File.ReadAllLines(filePath).Skip(1);

            foreach(string line in lines)
            {
                string[] parts = line.Split(',');


                if(parts.Length >= 4)
                {
                    try
                    {
                        int ID = int.Parse(parts[0]);
                        string Name = parts[1];
                        string Brand = parts[2];
                        decimal Price = decimal.Parse(parts[3]);


                        int Quantity = 0;

                        products.Add(new Product(ID, Name, Brand, Price, Quantity));
                    }
                    catch
                    {

                    }
                }
            }
            return products;


        }
        public static void SaveToCSV(string filePath, List<Products> products)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Name,ProductBrand,Price,Quantity");
            }
            foreach (var p in products)
            {
                // Converts price back to cents for storage and includes quantity
                string line = $"{p.ProductID},{p.ProductName},{p.ProductBrand},{p.ProductPrice * 100},{p.ProductQuantity}";
                writer.WriteLine(line);
            }

        }

    }
}
