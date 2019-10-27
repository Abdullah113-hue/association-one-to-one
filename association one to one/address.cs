using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace association_one_to_one
{
    class address
    {
        //public address(string number1, string number2, string number3, int number4, string number5)
        //{
        //    studentid = number1;
        //    studentname = number2;
        //    studentregno = number3;
        //    studenthouseno = number4;
        //    postercode = number5;
        //}

        //public address()
        //{

        //}

        public string  studentid { get; set; }
        public string studentname { get; set; }
        public string studentregno { get; set; }
        public int studenthouseno { get; set; }
        public string postercode { get; set; }
        public me pop { get; set; }

    }
}
