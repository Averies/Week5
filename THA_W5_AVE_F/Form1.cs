using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W5_AVE_F
{
    public partial class Form1 : Form
    {
        DataTable dtproduct;
        DataTable dtcategory;
        public List<string> category;
        string prevCategory = "";
        string prevCategoryf = "";
        public Form1()
        {
            InitializeComponent();
        }

        

        private void DataCategory()
        {
            category = new List<string>
            {
                "Jas",
                    "T-Shirt",
                    "Rok",
                    "Celana",
                    "Cawat"
            };
            dtproduct = new DataTable();
            dtproduct.Columns.Add("ID Product");
            dtproduct.Columns.Add("Nama Product");
            dtproduct.Columns.Add("Harga");
            dtproduct.Columns.Add("Stock");
            dtproduct.Columns.Add("ID Category");
            dtproduct.Rows.Add("J001", "Jas Hitam", "100000", "10", "C1");
            dtproduct.Rows.Add("T001", "T-Shirt Black Pink", "70000", "20", "C2");
            dtproduct.Rows.Add("T001", "T-Shirt Obsessive", "75000", "16", "C2");
            dtproduct.Rows.Add("R001", "Rok mini", "82000", "26", "C3");
            dtproduct.Rows.Add("J002", "Jeans Biru", "90000", "5", "C4");
            dtproduct.Rows.Add("C001", "Celana Pendek Coklat", "60000", "11", "C4");
            dtproduct.Rows.Add("C002", "Cawat Blink-blink", "10000000", "1", "C5");
            dtproduct.Rows.Add("R002", "Rocca Shirt", "50000", "8", "C2");
            
            dtcategory = new DataTable();
            dtcategory.Columns.Add("ID Category");
            dtcategory.Columns.Add("Nama Category");
            dtcategory.Rows.Add("C1", "Jas");
            dtcategory.Rows.Add("C2", "T-Shirt");
            dtcategory.Rows.Add("C3", "Rok");
            dtcategory.Rows.Add("C4", "Celana");
            dtcategory.Rows.Add("C5", "Cawat");
        }

        private void updatecomboCategory()
        {
            comboBox_category.Items.Clear();
            foreach(string c in category)
            {
                if(comboBox_filter.SelectedItem != null)
                {
                    if(comboBox_filter.SelectedItem.ToString() != c) 
                    {
                        comboBox_category.Items.Add(c);
                    }
                }
            }
            comboBox_category.SelectedItem = prevCategory;
        }

        private void updatecomboCategoryF()
        {
            comboBox_filter.Items.Clear();
            foreach(string c in category)
            {
                if(comboBox_category.SelectedItem != null) 
                {
                    if(comboBox_category.SelectedItem.ToString() != c)
                    {
                        comboBox_filter.Items.Add(c);
                    }
                }
            }
            comboBox_filter.SelectedItem = prevCategoryf;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataCategory();
            dgv_product.DataSource = dtproduct;
            dgv_category.DataSource = dtcategory;
            foreach(string c in category)
            {
                comboBox_category.Items.Add(c);
                comboBox_filter.Items.Add(c);
            }
        }

        private void comboBox_filter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_category.SelectedItem != null)
            {
                prevCategoryf = comboBox_category.SelectedItem.ToString();
                updatecomboCategory();
            }
        }

        private void comboBox_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_filter.SelectedItem != null)
            {
                prevCategory = comboBox_filter.SelectedItem.ToString();
                updatecomboCategoryF();
            }
        }
        
        private void btn_addP_Click(object sender, EventArgs e)
        {
            dtproduct.Rows.Add(textBox_nameP.Text, comboBox_category.SelectedItem.ToString(),
                textBox_harga.Text, textBox_stock.Text);
            textBox_nameP.Clear();
            textBox_harga.Clear();
            textBox_stock.Clear();
        }

        private void btn_addC_Click(object sender, EventArgs e)
        {
            dtcategory.Rows.Add("C"+(dtcategory.Rows.Count+1),textBox_nameC.Text);
            textBox_nameC.Clear();
        }

        private void btn_removeC_Click(object sender, EventArgs e)
        {
            dgv_category.Rows.RemoveAt(dgv_category.CurrentCell.RowIndex);
        }

        private void btn_editP_Click(object sender, EventArgs e)
        {

        }

        private void btn_removeP_Click(object sender, EventArgs e)
        {
            dgv_product.Rows.RemoveAt(dgv_product.CurrentCell.RowIndex);
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            comboBox_filter.Enabled = false;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            comboBox_filter.Enabled=true;
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox_filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
