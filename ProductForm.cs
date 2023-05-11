using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz
{
    public partial class ProductForm : Form
    {
        public Product Productt { get; set; }

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product product)
        {
            InitializeComponent();

            Productt = product;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            Productt = new Product()
            {
                Name = nameTB.Text.ToString(),
                Price = priceNumericUpDown.Value.ToString(),
                Quantity = quantityNumericUpDown.Value.ToString(),
                Country = countryComboBox.Text.ToString(),
                Discount = discountNumericUpDown.Value.ToString()
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}