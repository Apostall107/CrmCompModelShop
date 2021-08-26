
namespace Crm.UI.Forms
{
    partial class ProductForm
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
            this.name_Label = new System.Windows.Forms.Label();
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.add_Button = new System.Windows.Forms.Button();
            this.price_Label = new System.Windows.Forms.Label();
            this.quantity_Label = new System.Windows.Forms.Label();
            this.quantity_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.price_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Location = new System.Drawing.Point(23, 29);
            this.name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(55, 21);
            this.name_Label.TabIndex = 0;
            this.name_Label.Text = "Name:";
            // 
            // name_TextBox
            // 
            this.name_TextBox.Location = new System.Drawing.Point(86, 26);
            this.name_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(347, 29);
            this.name_TextBox.TabIndex = 1;
            // 
            // add_Button
            // 
            this.add_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.add_Button.Location = new System.Drawing.Point(321, 395);
            this.add_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(112, 37);
            this.add_Button.TabIndex = 2;
            this.add_Button.Text = "Add";
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // price_Label
            // 
            this.price_Label.AutoSize = true;
            this.price_Label.Location = new System.Drawing.Point(31, 68);
            this.price_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price_Label.Name = "price_Label";
            this.price_Label.Size = new System.Drawing.Size(47, 21);
            this.price_Label.TabIndex = 3;
            this.price_Label.Text = "Price:";
            // 
            // quantity_Label
            // 
            this.quantity_Label.AutoSize = true;
            this.quantity_Label.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.quantity_Label.Location = new System.Drawing.Point(10, 106);
            this.quantity_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantity_Label.Name = "quantity_Label";
            this.quantity_Label.Size = new System.Drawing.Size(68, 20);
            this.quantity_Label.TabIndex = 5;
            this.quantity_Label.Text = "Quantity:";
            // 
            // quantity_NumericUpDown
            // 
            this.quantity_NumericUpDown.Location = new System.Drawing.Point(86, 103);
            this.quantity_NumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.quantity_NumericUpDown.Name = "quantity_NumericUpDown";
            this.quantity_NumericUpDown.Size = new System.Drawing.Size(347, 29);
            this.quantity_NumericUpDown.TabIndex = 7;
            // 
            // price_NumericUpDown
            // 
            this.price_NumericUpDown.DecimalPlaces = 2;
            this.price_NumericUpDown.Location = new System.Drawing.Point(87, 66);
            this.price_NumericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.price_NumericUpDown.Name = "price_NumericUpDown";
            this.price_NumericUpDown.Size = new System.Drawing.Size(347, 29);
            this.price_NumericUpDown.TabIndex = 8;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 446);
            this.Controls.Add(this.price_NumericUpDown);
            this.Controls.Add(this.quantity_NumericUpDown);
            this.Controls.Add(this.quantity_Label);
            this.Controls.Add(this.price_Label);
            this.Controls.Add(this.add_Button);
            this.Controls.Add(this.name_TextBox);
            this.Controls.Add(this.name_Label);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.quantity_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.Label price_Label;
        private System.Windows.Forms.Label quantity_Label;
        private System.Windows.Forms.NumericUpDown quantity_NumericUpDown;
        private System.Windows.Forms.NumericUpDown price_NumericUpDown;
    }
}