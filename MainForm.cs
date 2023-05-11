using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dz
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            Product product = null;
            ProductForm productForm = new ProductForm();
            if(productForm.ShowDialog() == DialogResult.OK)
            {
                product = productForm.Productt;
                listBox1.Items.Add(product.Name);
                listBox1.Items.Add(product.Price);
                listBox1.Items.Add(product.Quantity);
                listBox1.Items.Add(product.Country);
                listBox1.Items.Add(product.Discount);
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("No selected Item!");
                return;
            }
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Product product = null;
            ProductForm productForm = new ProductForm();
            if (productForm.ShowDialog() == DialogResult.OK)
            {
                product = productForm.Productt;
                listBox1.Items.Add(product.Name);
                listBox1.Items.Add(product.Price);
                listBox1.Items.Add(product.Quantity);
                listBox1.Items.Add(product.Country);
                listBox1.Items.Add(product.Discount);
            }
        }
    }
}