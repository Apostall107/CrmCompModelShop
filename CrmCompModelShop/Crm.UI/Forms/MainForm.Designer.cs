
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
            this.sellerAdd_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customer_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerAdd_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.product_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productAdd_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheque_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.sellerAdd_ToolStripMenuItem});
            this.seller_ToolStripMenuItem.Name = "seller_ToolStripMenuItem";
            this.seller_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seller_ToolStripMenuItem.Text = "Seller";
            this.seller_ToolStripMenuItem.Click += new System.EventHandler(this.Seller_ToolStripMenuItem_Click);
            // 
            // sellerAdd_ToolStripMenuItem
            // 
            this.sellerAdd_ToolStripMenuItem.Name = "sellerAdd_ToolStripMenuItem";
            this.sellerAdd_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sellerAdd_ToolStripMenuItem.Text = "Add";
            // 
            // customer_ToolStripMenuItem
            // 
            this.customer_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerAdd_ToolStripMenuItem1});
            this.customer_ToolStripMenuItem.Name = "customer_ToolStripMenuItem";
            this.customer_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customer_ToolStripMenuItem.Text = "Customer";
            this.customer_ToolStripMenuItem.Click += new System.EventHandler(this.Customer_ToolStripMenuItem_Click);
            // 
            // customerAdd_ToolStripMenuItem1
            // 
            this.customerAdd_ToolStripMenuItem1.Name = "customerAdd_ToolStripMenuItem1";
            this.customerAdd_ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.customerAdd_ToolStripMenuItem1.Text = "Add";
            this.customerAdd_ToolStripMenuItem1.Click += new System.EventHandler(this.CustomerAdd_ToolStripMenuItem_Click);
            // 
            // product_ToolStripMenuItem
            // 
            this.product_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productAdd_ToolStripMenuItem});
            this.product_ToolStripMenuItem.Name = "product_ToolStripMenuItem";
            this.product_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.product_ToolStripMenuItem.Text = "Product";
            // 
            // productAdd_ToolStripMenuItem
            // 
            this.productAdd_ToolStripMenuItem.Name = "productAdd_ToolStripMenuItem";
            this.productAdd_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productAdd_ToolStripMenuItem.Text = "Add";
            // 
            // cheque_ToolStripMenuItem
            // 
            this.cheque_ToolStripMenuItem.Name = "cheque_ToolStripMenuItem";
            this.cheque_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cheque_ToolStripMenuItem.Text = "Cheque";
            this.cheque_ToolStripMenuItem.Click += new System.EventHandler(this.Cheque_ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
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
    }
}

