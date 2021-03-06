
namespace Crm.UI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seller_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerShow_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerAdd_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customer_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerShow_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerAdd_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.product_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productShow_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productAdd_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheque_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entityToolStripMenuItem,
            this.modelingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entityToolStripMenuItem
            // 
            this.entityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seller_ToolStripMenuItem,
            this.customer_ToolStripMenuItem,
            this.product_ToolStripMenuItem,
            this.cheque_ToolStripMenuItem});
            this.entityToolStripMenuItem.Name = "entityToolStripMenuItem";
            this.entityToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.entityToolStripMenuItem.Text = "Entity";
            // 
            // seller_ToolStripMenuItem
            // 
            this.seller_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellerShow_ToolStripMenuItem,
            this.sellerAdd_ToolStripMenuItem});
            this.seller_ToolStripMenuItem.Name = "seller_ToolStripMenuItem";
            this.seller_ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.seller_ToolStripMenuItem.Text = "Seller";
            this.seller_ToolStripMenuItem.Click += new System.EventHandler(this.Seller_ToolStripMenuItem_Click);
            // 
            // sellerShow_ToolStripMenuItem
            // 
            this.sellerShow_ToolStripMenuItem.Name = "sellerShow_ToolStripMenuItem";
            this.sellerShow_ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.sellerShow_ToolStripMenuItem.Text = "Show";
            this.sellerShow_ToolStripMenuItem.Click += new System.EventHandler(this.SellerShow_ToolStripMenuItem_Click);
            // 
            // sellerAdd_ToolStripMenuItem
            // 
            this.sellerAdd_ToolStripMenuItem.Name = "sellerAdd_ToolStripMenuItem";
            this.sellerAdd_ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.sellerAdd_ToolStripMenuItem.Text = "Add";
            this.sellerAdd_ToolStripMenuItem.Click += new System.EventHandler(this.SellerAdd_ToolStripMenuItem_Click);
            // 
            // customer_ToolStripMenuItem
            // 
            this.customer_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerShow_ToolStripMenuItem,
            this.customerAdd_ToolStripMenuItem1});
            this.customer_ToolStripMenuItem.Name = "customer_ToolStripMenuItem";
            this.customer_ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.customer_ToolStripMenuItem.Text = "Customer";
            this.customer_ToolStripMenuItem.Click += new System.EventHandler(this.Customer_ToolStripMenuItem_Click);
            // 
            // customerShow_ToolStripMenuItem
            // 
            this.customerShow_ToolStripMenuItem.Name = "customerShow_ToolStripMenuItem";
            this.customerShow_ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.customerShow_ToolStripMenuItem.Text = "Show";
            this.customerShow_ToolStripMenuItem.Click += new System.EventHandler(this.CustomerShow_ToolStripMenuItem_Click);
            // 
            // customerAdd_ToolStripMenuItem1
            // 
            this.customerAdd_ToolStripMenuItem1.Name = "customerAdd_ToolStripMenuItem1";
            this.customerAdd_ToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.customerAdd_ToolStripMenuItem1.Text = "Add";
            this.customerAdd_ToolStripMenuItem1.Click += new System.EventHandler(this.CustomerAdd_ToolStripMenuItem_Click);
            // 
            // product_ToolStripMenuItem
            // 
            this.product_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productShow_ToolStripMenuItem,
            this.productAdd_ToolStripMenuItem});
            this.product_ToolStripMenuItem.Name = "product_ToolStripMenuItem";
            this.product_ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.product_ToolStripMenuItem.Text = "Product";
            this.product_ToolStripMenuItem.Click += new System.EventHandler(this.Product_ToolStripMenuItem_Click);
            // 
            // productShow_ToolStripMenuItem
            // 
            this.productShow_ToolStripMenuItem.Name = "productShow_ToolStripMenuItem";
            this.productShow_ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.productShow_ToolStripMenuItem.Text = "Show";
            this.productShow_ToolStripMenuItem.Click += new System.EventHandler(this.productShow_ToolStripMenuItem_Click);
            // 
            // productAdd_ToolStripMenuItem
            // 
            this.productAdd_ToolStripMenuItem.Name = "productAdd_ToolStripMenuItem";
            this.productAdd_ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.productAdd_ToolStripMenuItem.Text = "Add";
            this.productAdd_ToolStripMenuItem.Click += new System.EventHandler(this.ProductAdd_ToolStripMenuItem_Click);
            // 
            // cheque_ToolStripMenuItem
            // 
            this.cheque_ToolStripMenuItem.Name = "cheque_ToolStripMenuItem";
            this.cheque_ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cheque_ToolStripMenuItem.Text = "Cheque";
            this.cheque_ToolStripMenuItem.Click += new System.EventHandler(this.Cheque_ToolStripMenuItem_Click);
            // 
            // modelingToolStripMenuItem
            // 
            this.modelingToolStripMenuItem.Name = "modelingToolStripMenuItem";
            this.modelingToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modelingToolStripMenuItem.Text = "Modeling";
            this.modelingToolStripMenuItem.Click += new System.EventHandler(this.modelingToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seller_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customer_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem product_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheque_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellerAdd_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerAdd_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productAdd_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellerShow_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerShow_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productShow_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelingToolStripMenuItem;
    }
}

