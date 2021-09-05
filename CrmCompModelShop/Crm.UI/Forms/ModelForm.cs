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
    public partial class ModelForm : Form
    {
        ShopComputerModel model = new ShopComputerModel();

        public ModelForm()
        {
            InitializeComponent();
        }

        private void test_Button_Click(object sender, EventArgs e)
        {
            List<CashDeskView> cashDeskViews = new List<CashDeskView>();


            for (int i = 0; i < model.CashDesks.Count; i++)
            {
                CashDeskView deskView = new CashDeskView(model.CashDesks[i], i, 10, 30 * i);

                cashDeskViews.Add(deskView);
                Controls.Add(deskView.CashDeskName);
                Controls.Add(deskView.CashDeskMoney);
                Controls.Add(deskView.QueueLenght);
                Controls.Add(deskView.CustomersLeftCount);
            }

            model.Start();

        }
    }
}
