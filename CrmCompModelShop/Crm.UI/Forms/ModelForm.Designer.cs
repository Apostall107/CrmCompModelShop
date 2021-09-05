
namespace Crm.UI.Forms
{
    partial class ModelForm
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
            this.test_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test_Button
            // 
            this.test_Button.Location = new System.Drawing.Point(552, 494);
            this.test_Button.Name = "test_Button";
            this.test_Button.Size = new System.Drawing.Size(87, 27);
            this.test_Button.TabIndex = 0;
            this.test_Button.Text = "Test";
            this.test_Button.UseVisualStyleBackColor = true;
            this.test_Button.Click += new System.EventHandler(this.test_Button_Click);
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 533);
            this.Controls.Add(this.test_Button);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ModelForm";
            this.Text = "ModelForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button test_Button;
    }
}