using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BL.Model
{
    public abstract class AbstractPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Cheque> Cheques { get; set; }
        public override string ToString()
        {
            // checks...

            return Name;
        }

    }
}
