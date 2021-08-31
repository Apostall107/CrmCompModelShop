using Crm.BL.Model;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Crm.UI.Forms
{
    public partial class Catalogue<T> : Form
        where T : class
    {
        private CrmContext db;
        private DbSet<T> dbSet;

        public Catalogue(DbSet<T> dbSet, CrmContext db)
        {
            InitializeComponent();
            this.db = db;
            this.dbSet = dbSet;
            dbSet.Load();
            dataGridView.DataSource = dbSet.Local.ToBindingList();
        }

        private void Catalogue_Load(object sender, EventArgs e)
        {
        }

        private void ChangeSelected_Button_Click(object sender, EventArgs e)
        {
            object id = dataGridView.SelectedRows[0].Cells[0].Value;

            if (typeof(T) == typeof(Product))
            {
                if (dbSet.Find(id) is Product product)
                {
                    ProductForm form = new ProductForm(product);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        product = form.Product;
                        db.SaveChanges();
                        dataGridView.Update();
                        dataGridView.Refresh();
                    }
                }
            }
            else if (typeof(T) == typeof(Seller))
            {
                if (dbSet.Find(id) is Seller seller)
                {
                    SellerForm form = new SellerForm(seller);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        seller = form.Seller;
                        db.SaveChanges();
                        dataGridView.Update();
                        dataGridView.Refresh();
                    }
                }
            }
            else if (typeof(T) == typeof(Customer))
            {
                if (dbSet.Find(id) is Customer customer)
                {
                    CustomerForm form = new CustomerForm(customer);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        customer = form.Customer;
                        db.SaveChanges();
                        dataGridView.Update();
                        dataGridView.Refresh();
                    }
                }
            }
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            dataGridView.Refresh();
        }
    }
}