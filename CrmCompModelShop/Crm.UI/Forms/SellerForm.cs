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
    public partial class SellerForm : Form
    {

        public Seller Seller { get; set; }


        public SellerForm()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {

            Seller = new Seller()
            {
                Name = name_TextBox.Text
            };
            Close();
        }
    }





}
