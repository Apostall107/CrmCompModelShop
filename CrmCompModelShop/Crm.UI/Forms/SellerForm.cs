using Crm.BL.Model;
using System;
using System.Windows.Forms;

namespace Crm.UI.Forms
{
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }

        public SellerForm()
        {
            InitializeComponent();
        }

        public SellerForm(Seller seller) : this()
        {
            Seller = seller ?? new Seller();
            name_TextBox.Text = Seller.Name;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Seller = Seller ?? new Seller();
            Seller.Name = name_TextBox.Text;

            Close();
        }
    }
}