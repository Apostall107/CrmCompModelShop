using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BL.Model
{
    public class ShopComputerModel
    {


        Generator Generator = new Generator();
        Random rnd = new Random();


        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public List<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
        public List<Cheque> Cheques { get; set; } = new List<Cheque>();
        public List<Selling> Sellings { get; set; } = new List<Selling>();
        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();





        public ShopComputerModel()
        {
            List<Seller> sellers = Generator.GetNewSellers(20);
            Generator.GetNewProducts(1000);
            Generator.GetNewCustomers(50);

            foreach (Seller seller in sellers)
            {
                Sellers.Enqueue(seller);
            }

            for (int i = 0; i < 3; i++)
            {
                CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue()));
            }
        }



        public void Start()
        {

            List<Customer> customers = Generator.GetNewCustomers(15);

            Queue<ShoppingCart> shoppingCarts = new Queue<ShoppingCart>();


            //feels up carts with products.
            foreach (Customer customer in customers)
            {
                ShoppingCart cart = new ShoppingCart(customer);

                foreach (Product product in Generator.GetRandomProducts(1, 30))
                {
                    cart.Add(product);
                }
                shoppingCarts.Enqueue(cart);

            }



            // customers/carts take a place in desks.
            while (shoppingCarts.Count > 0)
            {
                //Choose desk with shortest queue.
                CashDesk cashDesk = CashDesks.OrderBy(x => x.Count).FirstOrDefault();
                cashDesk.Enqueue(shoppingCarts.Dequeue());

            }


            // desks work all the time.
            while (true)
            {
                CashDesk cashDesk = CashDesks.OrderBy(c => c.Count).FirstOrDefault();
                var money = cashDesk.Dequeue();
            }



        }

        //public void Stop()
        //{

        //}

        //private void CashDeskWork(CashDesk cashDesk)
        //{

        //}

        //private void CreateCarts(int customerCounts)
        //{


        //}
    }
}
