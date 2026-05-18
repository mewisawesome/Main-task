using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                        int id = int.Parse(parts[0]);
                        string name = parts[1];
                        string brand = parts[2];
                        decimal price = decimal.Parse(parts[3]);


                        int quantity = 0;

                        products.Add(new Product(id, name, brand, price, quantity));
                    }
                    catch
                    {

                    }
                }
            }
            return products;


        }
        public static void SaveToCSV(string filePath, List<Product>  products)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Name,Brand,Price,Quantity");

                foreach (var p in products)
                {
                    // Converts price back to cents for storage and includes quantity
                    string line = $"{p.ID1},{p.Name1},{p._brand},{p.Price1 * 100},{p.Quantity1}";
                    writer.WriteLine(line);
                }
            }

        }

    }
}
