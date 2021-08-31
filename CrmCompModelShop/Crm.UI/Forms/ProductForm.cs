using Crm.BL.Model;
using System;
using System.Windows.Forms;

namespace Crm.UI.Forms
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product product) : this()
        {
            Product = product ?? new Product();
            name_TextBox.Text = Product.Name;
            price_NumericUpDown.Value = Product.Price;
            quantity_NumericUpDown.Value = Product.Quantity;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Product = new Product()
            {
                Name = name_TextBox.Text,
                Price = price_NumericUpDown.Value,
                Quantity = (int)quantity_NumericUpDown.Value
            };
            Close();
        }
    }
}