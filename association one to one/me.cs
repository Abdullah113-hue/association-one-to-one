using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace association_one_to_one
{
    class me
    {
     
       
        public string  first { get; set; }
        public string secound { get; set; }
        public string third { get; set; }
        public address wwe { get; set; }


        public string all()
        {
            string full = first + " " + secound + " " + third;
            return full;
        }
    }
}
