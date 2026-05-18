using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_task
{
    internal class Product
    {
        public int ID1 { get; set; }
        public string Name1 { get; set; }
        public string _brand { get; set; }
        public decimal Price1 { get; set; }
        public int Quantity1 { get; set; }

        public Product(int id, string name, string brand, decimal price, int quantity)
        {
            ID1 = id;
            Name1 = name;
            _brand = brand;
            Price1 = price;
            Quantity1 = quantity;
        }

    }

}


