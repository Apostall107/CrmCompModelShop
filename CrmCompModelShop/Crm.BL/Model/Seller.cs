﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BL.Model
{
    public class Seller
    {


        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            // checks...

            return Name;
        }






    }
}
