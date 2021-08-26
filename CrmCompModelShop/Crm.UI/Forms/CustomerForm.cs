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
    public partial class CustomerForm : Form
    {

        public Customer Customer { get; set; }


        public CustomerForm()
        {
            InitializeComponent();
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
