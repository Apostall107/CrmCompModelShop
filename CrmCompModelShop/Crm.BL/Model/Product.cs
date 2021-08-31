using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BL.Model
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<Selling> Sellings { get; set; }

        public override string ToString()
        {
            //some checks...

            return $"{Name} - {Price}";
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public override bool Equals(object obj)
        {
            if (obj is Product product)
            {
                return this.Id.Equals(product.Id);
            }

            return false;
        }
    }
}
