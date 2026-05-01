namespace Main_task
{
    partial class PayArea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPay = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quanity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPay2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.pnlPay.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPay
            // 
            this.pnlPay.BackColor = System.Drawing.Color.DarkGray;
            this.pnlPay.Controls.Add(this.button12);
            this.pnlPay.Controls.Add(this.button11);
            this.pnlPay.Controls.Add(this.button10);
            this.pnlPay.Controls.Add(this.button9);
            this.pnlPay.Controls.Add(this.button8);
            this.pnlPay.Controls.Add(this.button7);
            this.pnlPay.Controls.Add(this.button6);
            this.pnlPay.Controls.Add(this.button5);
            this.pnlPay.Controls.Add(this.button4);
            this.pnlPay.Controls.Add(this.button3);
            this.pnlPay.Controls.Add(this.button2);
            this.pnlPay.Controls.Add(this.button1);
            this.pnlPay.Controls.Add(this.btnPay2);
            this.pnlPay.Controls.Add(this.dataGridView1);
            this.pnlPay.Controls.Add(this.panel1);
            this.pnlPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPay.Location = new System.Drawing.Point(0, 0);
            this.pnlPay.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(800, 450);
            this.pnlPay.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 450);
            this.panel1.TabIndex = 1;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(16, 354);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(137, 74);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(16, 183);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(137, 78);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(16, 15);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(137, 80);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home page";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Product,
            this.Price,
            this.Quanity});
            this.dataGridView1.Location = new System.Drawing.Point(175, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(625, 444);
            this.dataGridView1.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quanity
            // 
            this.Quanity.HeaderText = "Quanity";
            this.Quanity.Name = "Quanity";
            this.Quanity.ReadOnly = true;
            // 
            // btnPay2
            // 
            this.btnPay2.Location = new System.Drawing.Point(690, 379);
            this.btnPay2.Name = "btnPay2";
            this.btnPay2.Size = new System.Drawing.Size(107, 59);
            this.btnPay2.TabIndex = 6;
            this.btnPay2.Text = "Pay";
            this.btnPay2.UseVisualStyleBackColor = true;
            this.btnPay2.Click += new System.EventHandler(this.btnPay2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(625, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(625, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(625, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(625, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(625, 332);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(709, 44);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "Remove";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(709, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "Remove";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(709, 154);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(61, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "Remove";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(709, 211);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(61, 23);
            this.button10.TabIndex = 19;
            this.button10.Text = "Remove";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(709, 275);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(61, 23);
            this.button11.TabIndex = 20;
            this.button11.Text = "Remove";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(709, 332);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(61, 23);
            this.button12.TabIndex = 21;
            this.button12.Text = "Remove";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // PayArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPay);
            this.Name = "PayArea";
            this.Text = "PayArea";
            this.Load += new System.EventHandler(this.PayArea_Load);
            this.pnlPay.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quanity;
        private System.Windows.Forms.Button btnPay2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
    }
}