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
    public partial class PayArea : Form
    {
        public PayArea()
        {
            InitializeComponent();
        }

        private void PayArea_Load(object sender, EventArgs e)
        {

        }


        private void ShowScreen(UserControl newScreen)
        {
            foreach (Control ctrl in pnlPay.Controls)
            {
                ctrl.Dispose();
            }
            pnlPay.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;
            pnlPay.Controls.Add(newScreen);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Checkout());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnPay2_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Pay());
        }
    }
}
