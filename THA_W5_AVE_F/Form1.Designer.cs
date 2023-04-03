namespace THA_W5_AVE_F
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.btn_All = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.comboBox_filter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nameC = new System.Windows.Forms.TextBox();
            this.btn_addC = new System.Windows.Forms.Button();
            this.btn_removeC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_nameP = new System.Windows.Forms.TextBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.textBox_harga = new System.Windows.Forms.TextBox();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.btn_addP = new System.Windows.Forms.Button();
            this.btn_removeP = new System.Windows.Forms.Button();
            this.btn_editP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // dgv_product
            // 
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(17, 77);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowHeadersWidth = 62;
            this.dgv_product.RowTemplate.Height = 28;
            this.dgv_product.Size = new System.Drawing.Size(698, 388);
            this.dgv_product.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(781, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // dgv_category
            // 
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Location = new System.Drawing.Point(776, 77);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.RowHeadersWidth = 62;
            this.dgv_category.RowTemplate.Height = 28;
            this.dgv_category.Size = new System.Drawing.Size(428, 265);
            this.dgv_category.TabIndex = 3;
            // 
            // btn_All
            // 
            this.btn_All.Location = new System.Drawing.Point(376, 35);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(65, 33);
            this.btn_All.TabIndex = 4;
            this.btn_All.Text = "All";
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(447, 35);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(60, 33);
            this.btn_filter.TabIndex = 5;
            this.btn_filter.Text = "Filter:";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // comboBox_filter
            // 
            this.comboBox_filter.FormattingEnabled = true;
            this.comboBox_filter.Location = new System.Drawing.Point(513, 38);
            this.comboBox_filter.Name = "comboBox_filter";
            this.comboBox_filter.Size = new System.Drawing.Size(143, 28);
            this.comboBox_filter.TabIndex = 6;
            this.comboBox_filter.SelectedIndexChanged += new System.EventHandler(this.comboBox_filter_SelectedIndexChanged);
            this.comboBox_filter.SelectionChangeCommitted += new System.EventHandler(this.comboBox_filter_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(791, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama :";
            // 
            // textBox_nameC
            // 
            this.textBox_nameC.Location = new System.Drawing.Point(867, 372);
            this.textBox_nameC.Name = "textBox_nameC";
            this.textBox_nameC.Size = new System.Drawing.Size(235, 26);
            this.textBox_nameC.TabIndex = 8;
            // 
            // btn_addC
            // 
            this.btn_addC.Location = new System.Drawing.Point(843, 420);
            this.btn_addC.Name = "btn_addC";
            this.btn_addC.Size = new System.Drawing.Size(105, 54);
            this.btn_addC.TabIndex = 9;
            this.btn_addC.Text = "Add Category";
            this.btn_addC.UseVisualStyleBackColor = true;
            this.btn_addC.Click += new System.EventHandler(this.btn_addC_Click);
            // 
            // btn_removeC
            // 
            this.btn_removeC.Location = new System.Drawing.Point(971, 420);
            this.btn_removeC.Name = "btn_removeC";
            this.btn_removeC.Size = new System.Drawing.Size(99, 54);
            this.btn_removeC.TabIndex = 10;
            this.btn_removeC.Text = "Remove Category";
            this.btn_removeC.UseVisualStyleBackColor = true;
            this.btn_removeC.Click += new System.EventHandler(this.btn_removeC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 663);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stock :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 624);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Harga :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 582);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Category :";
            // 
            // textBox_nameP
            // 
            this.textBox_nameP.Location = new System.Drawing.Point(108, 538);
            this.textBox_nameP.Name = "textBox_nameP";
            this.textBox_nameP.Size = new System.Drawing.Size(311, 26);
            this.textBox_nameP.TabIndex = 16;
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(108, 579);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(148, 28);
            this.comboBox_category.TabIndex = 17;
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            this.comboBox_category.SelectionChangeCommitted += new System.EventHandler(this.comboBox_category_SelectionChangeCommitted);
            // 
            // textBox_harga
            // 
            this.textBox_harga.Location = new System.Drawing.Point(108, 621);
            this.textBox_harga.Name = "textBox_harga";
            this.textBox_harga.Size = new System.Drawing.Size(148, 26);
            this.textBox_harga.TabIndex = 18;
            // 
            // textBox_stock
            // 
            this.textBox_stock.Location = new System.Drawing.Point(108, 660);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.Size = new System.Drawing.Size(148, 26);
            this.textBox_stock.TabIndex = 19;
            // 
            // btn_addP
            // 
            this.btn_addP.Location = new System.Drawing.Point(338, 592);
            this.btn_addP.Name = "btn_addP";
            this.btn_addP.Size = new System.Drawing.Size(103, 55);
            this.btn_addP.TabIndex = 20;
            this.btn_addP.Text = "Add Product";
            this.btn_addP.UseVisualStyleBackColor = true;
            this.btn_addP.Click += new System.EventHandler(this.btn_addP_Click);
            // 
            // btn_removeP
            // 
            this.btn_removeP.Location = new System.Drawing.Point(583, 592);
            this.btn_removeP.Name = "btn_removeP";
            this.btn_removeP.Size = new System.Drawing.Size(103, 55);
            this.btn_removeP.TabIndex = 21;
            this.btn_removeP.Text = "Remove Product";
            this.btn_removeP.UseVisualStyleBackColor = true;
            this.btn_removeP.Click += new System.EventHandler(this.btn_removeP_Click);
            // 
            // btn_editP
            // 
            this.btn_editP.Location = new System.Drawing.Point(460, 592);
            this.btn_editP.Name = "btn_editP";
            this.btn_editP.Size = new System.Drawing.Size(103, 55);
            this.btn_editP.TabIndex = 22;
            this.btn_editP.Text = "Edit Product";
            this.btn_editP.UseVisualStyleBackColor = true;
            this.btn_editP.Click += new System.EventHandler(this.btn_editP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1247, 722);
            this.Controls.Add(this.btn_editP);
            this.Controls.Add(this.btn_removeP);
            this.Controls.Add(this.btn_addP);
            this.Controls.Add(this.textBox_stock);
            this.Controls.Add(this.textBox_harga);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.textBox_nameP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_removeC);
            this.Controls.Add(this.btn_addC);
            this.Controls.Add(this.textBox_nameC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_filter);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.btn_All);
            this.Controls.Add(this.dgv_category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Blink Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ComboBox comboBox_filter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nameC;
        private System.Windows.Forms.Button btn_addC;
        private System.Windows.Forms.Button btn_removeC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_nameP;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.TextBox textBox_harga;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.Button btn_addP;
        private System.Windows.Forms.Button btn_removeP;
        private System.Windows.Forms.Button btn_editP;
    }
}

