namespace Main_task
{
    partial class UC_Checkout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quanity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPay2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(579, 432);
            this.dataGridView1.TabIndex = 4;
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
            this.btnPay2.Location = new System.Drawing.Point(578, 385);
            this.btnPay2.Name = "btnPay2";
            this.btnPay2.Size = new System.Drawing.Size(107, 59);
            this.btnPay2.TabIndex = 5;
            this.btnPay2.Text = "Pay";
            this.btnPay2.UseVisualStyleBackColor = true;
            this.btnPay2.Click += new System.EventHandler(this.btnPay2_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(453, 37);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(61, 23);
            this.btnAdd2.TabIndex = 7;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemove2
            // 
            this.btnRemove2.Location = new System.Drawing.Point(518, 37);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(61, 23);
            this.btnRemove2.TabIndex = 8;
            this.btnRemove2.Text = "Remove";
            this.btnRemove2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(453, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(453, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(453, 292);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(453, 356);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(518, 97);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Remove";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(518, 159);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "Remove";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(518, 228);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(61, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "Remove";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(518, 292);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(61, 23);
            this.button10.TabIndex = 17;
            this.button10.Text = "Remove";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(518, 356);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(61, 23);
            this.button11.TabIndex = 18;
            this.button11.Text = "Remove";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // UC_Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemove2);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.btnPay2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UC_Checkout";
            this.Size = new System.Drawing.Size(768, 513);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quanity;
        private System.Windows.Forms.Button btnPay2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}
