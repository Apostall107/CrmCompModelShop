using Crm.BL.Model;
using System;
using System.Windows.Forms;

namespace Crm.UI.Forms
{
    public partial class MainForm : Form
    {
        private CrmContext db;

        public MainForm()
        {
            InitializeComponent();
            db = new CrmContext();
        }

        #region EntitiesMenu

        #region SellerOptions

        private void Seller_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogue<Seller> catalogueSeller = new Catalogue<Seller>(db.Sellers, db);
            catalogueSeller.Show();
        }

        private void SellerShow_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seller_ToolStripMenuItem_Click(sender, e);
        }

        private void SellerAdd_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();

            if (sellerForm.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(sellerForm.Seller);
                db.SaveChanges();
            }
        }

        #endregion SellerOptions

        #region CustomerOptions

        private void Customer_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogue<Customer> catalogueCustomer = new Catalogue<Customer>(db.Customers, db);
            catalogueCustomer.Show();
        }

        private void CustomerShow_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_ToolStripMenuItem_Click(sender, e);
        }

        private void CustomerAdd_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();

            if (customerForm.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(customerForm.Customer);
                db.SaveChanges();
            }
        }

        #endregion CustomerOptions

        #region ProductOptions

        private void Product_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogue<Product> catalogueProduct = new Catalogue<Product>(db.Products, db);
            catalogueProduct.Show();
        }

        private void productShow_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_ToolStripMenuItem_Click(sender, e);
        }

        private void ProductAdd_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();

            if (productForm.ShowDialog() == DialogResult.OK)
            {
                db.Products.Add(productForm.Product);
                db.SaveChanges();
            }
        }

        #endregion ProductOptions

        private void Cheque_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogue<Cheque> catalogueCheque = new Catalogue<Cheque>(db.Cheques, db);
            catalogueCheque.Show();
        }

        #endregion EntitiesMenu
    }
}