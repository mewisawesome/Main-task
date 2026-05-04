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
    public partial class BacktoPay : Form
    {
        public BacktoPay()
        {
            InitializeComponent();
        }

        private void BacktoPay_Load(object sender, EventArgs e)
        {

        }
        private void ShowScreen(UserControl newScreen)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                ctrl.Dispose();
            }
            panel1.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;
            panel1.Controls.Add(newScreen);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ShowScreen(new UC_Pay());
        }
    }
}
