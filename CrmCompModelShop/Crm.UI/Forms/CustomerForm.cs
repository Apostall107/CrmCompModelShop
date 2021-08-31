using Crm.BL.Model;
using System;
using System.Windows.Forms;

namespace Crm.UI.Forms
{
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; set; }

        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(Customer customer) : this()
        {
            Customer = customer ?? new Customer();
            name_TextBox.Text = Customer.Name;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Customer = new Customer()
            {
                Name = name_TextBox.Text
            };
            Close();
        }
    }
}