using System;
using System.Collections.Generic;

//TODO:
namespace Crm.BL.Model
{
    public class CashDesk
    {
        private CrmContext db = new CrmContext();

        public int DeskNo { get; set; }
        public Seller Seller { get; set; }
        public Queue<ShoppingCart> Queue { get; set; }
        public int MaxQueueLenght { get; set; }
        public int CustomersLeftCounter { get; set; }
        public bool IsModel { get; set; }
        public int Count => Queue.Count;

        public event EventHandler<Cheque> ChequeClosed;

        public CashDesk(int deskNo, Seller seller)
        {
            DeskNo = deskNo;
            Seller = seller;
            Queue = new Queue<ShoppingCart>();
            IsModel = true;
            MaxQueueLenght = 10;
        }

        public void Enqueue(ShoppingCart cart)
        {
            if (Queue.Count <= MaxQueueLenght)
            {
                Queue.Enqueue(cart);
            }
            else
            {
                CustomersLeftCounter++;
            }
        }

        public decimal Dequeue()
        {
            decimal sum = 0;
            if (Queue.Count == 0)
            {
                return 0;
            }

            ShoppingCart cart = Queue.Dequeue();

            if (cart != null)
            {
                Cheque cheque = new Cheque()
                {
                    SellerId = Seller.Id,
                    Seller = Seller,
                    CustomerId = cart.Customer.Id,
                    Customer = cart.Customer,
                    Created = DateTime.Now
                };

                if (IsModel != true)
                {
                    db.Cheques.Add(cheque);
                    db.SaveChanges();
                }
                else
                {
                    cheque.Id = 0;
                }

                List<Selling> sellings = new List<Selling>();

                foreach (Product product in cart)
                {
                    if (product.QuantityAvaliable > 0)
                    {
                        Selling selling = new Selling()
                        {
                            ChequeId = cheque.Id,
                            Cheque = cheque,
                            ProductId = product.Id,
                            Product = product
                        };

                        sellings.Add(selling);

                        if (IsModel != true)
                        {
                            db.Sellings.Add(selling);
                        }
                        product.QuantityAvaliable--;
                        sum += product.Price;
                    }
                }

                cheque.Outcome = sum;


                if (IsModel != true)
                {
                    db.SaveChanges();
                }

                ChequeClosed?.Invoke(this, cheque);

            }

            return sum;
        }

        public override string ToString()
        {
            return $"Cash desk №{DeskNo}";
        }
    }
}