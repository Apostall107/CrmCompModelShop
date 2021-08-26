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
    public partial class MainForm : Form
    {
        readonly CrmContext crmContext;
        public MainForm()
        {
            InitializeComponent();
            crmContext = new CrmContext();
        }



        #region EntitiesMenu

        #region SellerOptions

        private void Seller_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogue<Seller> catalogueSeller = new Catalogue<Seller>(crmContext.Sellers);
            catalogueSeller.Show();
        }

        private void SellerAdd_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SellerForm sellerForm = new SellerForm();

            if (sellerForm.ShowDialog() == DialogResult.OK)
            {

                crmContext.Sellers.Add(sellerForm.Seller);
                crmContext.SaveChanges();


            }

        }
        #endregion

        #region CustomerOptions

        private void Customer_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogue<Customer> catalogueCustomer = new Catalogue<Customer>(crmContext.Customers);
            catalogueCustomer.Show();
        }


        private void CustomerAdd_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CustomerForm customerForm = new CustomerForm();

            if (customerForm.ShowDialog() == DialogResult.OK)
            {

                crmContext.Customers.Add(customerForm.Customer);
                crmContext.SaveChanges();


            }


        }

        #endregion


        #region ProductOptions

        private void Product_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogue<Product> catalogueProduct = new Catalogue<Product>(crmContext.Products);
            catalogueProduct.Show();
        }
        private void ProductAdd_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ProductForm productForm = new ProductForm();

            if (productForm.ShowDialog() == DialogResult.OK)
            {

                crmContext.Products.Add(productForm.Product);
                crmContext.SaveChanges();


            }

        }



        #endregion





        private void Cheque_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogue<Cheque> catalogueCheque = new Catalogue<Cheque>(crmContext.Cheques);
            catalogueCheque.Show();

        }











        #endregion








    }
}
