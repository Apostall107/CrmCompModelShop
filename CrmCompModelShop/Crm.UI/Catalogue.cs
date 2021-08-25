﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crm.UI
{
    public partial class Catalogue<T> : Form 
        where T : class
    {


        public Catalogue(DbSet<T> dbSet)
        {
            InitializeComponent();
            dataGridView.DataSource = dbSet.Local.ToBindingList();
        }


        private void Catalogue_Load(object sender, EventArgs e)
        {

        }
    }
}
