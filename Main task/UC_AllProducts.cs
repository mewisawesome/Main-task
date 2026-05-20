using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_task
{
    public partial class UC_AllProducts : UserControl
    {
        private BindingList<Product> _inventoryList = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();

        string filePath = "./book.csv";
        public UC_AllProducts()
        {
            InitializeComponent();
        }
        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            string path = filePath;

            // 1. Load the data into a temporary list
            var tempData = InventoryService.LoadFromCSV(path);

            // 2. Clear the BindingList and add the loaded data
            _inventoryList.Clear();
            foreach (var item in tempData)
            {
                _inventoryList.Add(item);
            }

            // 3. Bind the BindingList to the grid
            dataGridView2.DataSource = _inventoryList;
        }
        
    }
}
