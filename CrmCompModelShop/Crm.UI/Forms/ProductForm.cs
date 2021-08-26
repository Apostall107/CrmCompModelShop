using Crm.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
