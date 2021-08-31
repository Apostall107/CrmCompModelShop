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

        public bool IsNotModel { get; set; }

        public CashDesk(int deskNo, Seller seller)
        {
            DeskNo = deskNo;
            Seller = seller;
            Queue = new Queue<ShoppingCart>();
            IsNotModel = false;
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
            decimal  sum = 0m;
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

                if (IsNotModel)
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
                    if (product.Quantity > 0)
                    {
                        Selling selling = new Selling()
                        {
                            ChequeId = cheque.Id,
                            Cheque = cheque,
                            ProductId = product.Id,
                            Product = product
                        };

                        sellings.Add(selling);

                        if (IsNotModel)
                        {
                            db.Sellings.Add(selling);
                        }
                        product.Quantity--;
                        sum += product.Price;
                    }
                }

                if (IsNotModel)
                {
                    db.SaveChanges();
                }

            }

            return sum;
        }



    }
}