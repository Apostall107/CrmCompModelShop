using Crm.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crm.UI
{
    class CashDeskView
    {
        CashDesk cashDesk;

        public Label CashDeskName { get; set; }
        public NumericUpDown CashDeskMoney { get; set; }
        public ProgressBar QueueLenght { get; set; }
        public Label CustomersLeftCount { get; set; }

        public CashDeskView(CashDesk cashDesk, int number, int x, int y)
        {
            this.cashDesk = cashDesk;

            CashDeskName = new Label();
            CashDeskMoney = new NumericUpDown();
            QueueLenght = new ProgressBar();
            CustomersLeftCount = new Label();

            CashDeskName.AutoSize = true;
            CashDeskName.Location = new System.Drawing.Point(x, y+5);
            CashDeskName.Name = "label" + number;
            CashDeskName.Size = new System.Drawing.Size(35, 13);
            CashDeskName.TabIndex = number;
            CashDeskName.Text = cashDesk.ToString();


            CashDeskMoney.Location = new System.Drawing.Point(x + 100, y);
            CashDeskMoney.Name = "numericUpDown" + number;
            CashDeskMoney.Size = new System.Drawing.Size(120, 20);
            CashDeskMoney.TabIndex = number;
            CashDeskMoney.Maximum = decimal.MaxValue;

            QueueLenght.Location = new System.Drawing.Point(x + 250, y);
            QueueLenght.Maximum = cashDesk.MaxQueueLenght;
            QueueLenght.Name = "progressBar" + number;
            QueueLenght.Size = new System.Drawing.Size(100, 23);
            QueueLenght.TabIndex = number;
            QueueLenght.Value = 0;

            CustomersLeftCount.AutoSize = true;
            CustomersLeftCount.Location = new System.Drawing.Point(x + 400, y);
            CustomersLeftCount.Name = "label2" + number;
            CustomersLeftCount.Size = new System.Drawing.Size(35, 13);
            CustomersLeftCount.TabIndex = number;
            CustomersLeftCount.Text = "";

            cashDesk.ChequeClosed += CashDesk_ChequeClosed;
        }

        private void CashDesk_ChequeClosed(object sender, Cheque e)
        {
            CashDeskMoney.Invoke((Action)delegate { CashDeskMoney.Value += e.Outcome; } );
        }
    }
}
