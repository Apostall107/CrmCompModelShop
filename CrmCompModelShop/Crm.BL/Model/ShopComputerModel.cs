using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Crm.BL.Model
{
    public class ShopComputerModel
    {


        Generator Generator = new Generator();
        Random rnd = new Random();

        bool isWorking = false;

        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public List<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
        public List<Cheque> Cheques { get; set; } = new List<Cheque>();
        public List<Selling> Sellings { get; set; } = new List<Selling>();
        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();





        public ShopComputerModel()
        {
            List<Seller> sellers = Generator.GetNewSellers(8);
            Generator.GetNewProducts(1000);
            Generator.GetNewCustomers(60);

            foreach (Seller seller in sellers)
            {
                Sellers.Enqueue(seller);
            }

            for (int i = 0; i < 5; i++)
            {
                CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue()));
            }
        }



        public void Start()
        {

            isWorking = true;
            Task.Run(()=>CreateCarts(15, 800));


            // creating  collection of task for  working cash desks. 
            IEnumerable<Task> cashDeskTasks = CashDesks.Select(x => new Task(() => CashDeskWork(x, rnd.Next(200,1000) )));


            // Starting all tasks for cash desks.
            foreach (Task task in cashDeskTasks)
            {
                task.Start();
            }

        }

        public void Stop()
        {
            isWorking = false;
            Thread.Sleep(1000);
        }

        private void CashDeskWork(CashDesk cashDesk, int sleep)
        {
            while (isWorking)
            {

                if (cashDesk.Count > 0 )
                {
                    cashDesk.Dequeue();
                    Thread.Sleep(sleep);
                }

            }
        }

        private void CreateCarts(int customersQuantity, int sleep)
        {
            while (isWorking)
            {
                List<Customer> customers = Generator.GetNewCustomers(customersQuantity);


                foreach (Customer customer in customers)
                {
                 
                    ShoppingCart cart = new ShoppingCart(customer);
                    // feels up carts with products.
                    foreach (Product product in Generator.GetRandomProducts(10,30))
                    {
                        cart.Add(product);
                    }

                    //Choose desk with shortest queue.
                    //CashDesk cashDesk = CashDesks[rnd.Next(CashDesks.Count)];

                    CashDesk cashDesk = CashDesks.OrderBy(x => x.Count).FirstOrDefault();

                    cashDesk.Enqueue(cart);
                }

                Thread.Sleep(sleep);

            }
        }
    }
}
