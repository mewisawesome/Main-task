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
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
        }

        private void BtnBackToPay_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            ShowScreen(new Purchase());
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
    }
}
