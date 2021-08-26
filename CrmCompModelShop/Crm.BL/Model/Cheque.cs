using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public virtual ICollection<Transaction> Transactions { get; set; }


        public override string ToString()
        {
            return $"№ {Id}. date: {Created:dd.mm.yyyy hh:mm:ss} "; 
        }


    }
}
