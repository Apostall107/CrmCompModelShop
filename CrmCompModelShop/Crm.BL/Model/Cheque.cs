using System;
using System.Collections.Generic;

namespace Crm.BL.Model
{
    public class Cheque
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public int SellerId { get; set; }

        public virtual Seller Seller { get; set; }

        public DateTime Created { get; set; }

        public decimal Outcome { get; set; }

        public virtual ICollection<Selling> Sellings { get; set; }

        public override string ToString()
        {
            return $"№ {Id}. date: {Created:dd.mm.yyyy hh:mm:ss} ";
        }
    }
}