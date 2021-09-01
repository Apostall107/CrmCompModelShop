using System;
using System.Collections.Generic;

namespace Crm.BL.Model
{
    public class Generator
    {
        private Random rnd = new Random();

        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }
        public List<Seller> Sellers { get; set; }

        public List<Customer> GetNewCustomers(int count)
        {
            List<Customer> result = new List<Customer>();

            for (int i = 0; i < count; i++)
            {
                Customer customer = new Customer()
                {
                    Id = Customers.Count,
                    Name = GetRandomText()
                };
                Customers.Add(customer);
                result.Add(customer);
            }

            return result;
        }

        public List<Seller> GetNewSellers(int count)
        {
            List<Seller> result = new List<Seller>();

            for (int i = 0; i < count; i++)
            {
                Seller seller = new Seller()
                {
                    Id = Sellers.Count,
                    Name = GetRandomText()
                };
                Sellers.Add(seller);
                result.Add(seller);
            }

            return result;
        }

        public List<Product> GetNewProducts(int count)
        {
            List<Product> result = new List<Product>();

            for (int i = 0; i < count; i++)
            {
                Product product = new Product()
                {
                    Id = Products.Count,
                    Name = GetRandomText(),
                    QuantityAvaliable = rnd.Next(10, 1000),
                    Price = Convert.ToDecimal(rnd.Next(5, 100000) + rnd.NextDouble())
                };
                Products.Add(product);
                result.Add(product);
            }

            return result;
        }

        public List<Product> GetRandomProducts(int min, int max)
        {
            List<Product> result = new List<Product>();

            int count = rnd.Next(min, max);
            for (int i = 0; i < count; i++)
            {
                result.Add(Products[rnd.Next(Products.Count - 1)]);
            }

            return result;
        }

        private static string GetRandomText()
        {
            return Guid.NewGuid().ToString().Substring(0, 5);
        }
    }
}