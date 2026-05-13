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
    public partial class Items : UserControl
    {
        private BindingList<Product> _inventory = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();

        String filePath = "H:/Programming/Main task/Book(Sheet1) (1).csv";

        public Items()
        {
            InitializeComponent();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            var tempData = InventoryService.LoadFromCSV(filePath);

            _inventoryList.Clear();
            foreach(var item in tempData)
            {
                _inventoryList.Add(item);
            }
            dataGridView2.DataSource = _inventoryList;
        }
    }
}
