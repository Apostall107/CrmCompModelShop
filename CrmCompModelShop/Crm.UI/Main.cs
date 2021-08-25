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

namespace Crm.UI
{
    public partial class Main : Form
    {
        CrmContext crmContext;
        public Main()
        {
            InitializeComponent();
            crmContext = new CrmContext();
        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogue<Seller> catalogueSeller = new Catalogue<Seller>(crmContext.Sellers);
            catalogueSeller.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogue<Customer> catalogueCustomer = new Catalogue<Customer>(crmContext.Customers);
            catalogueCustomer.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogue<Product> catalogueProduct = new Catalogue<Product>(crmContext.Products);
            catalogueProduct.Show();
        }

        private void chequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogue<Cheque> catalogueCheque = new Catalogue<Cheque>(crmContext.Cheques);
            catalogueCheque.Show();

        }


    }
}
