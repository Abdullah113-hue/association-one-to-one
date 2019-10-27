using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace association_one_to_one
{
    class Program
    {
        static void Main(string[] args)
        {
            address use = new address();

            use.studentid = "23";
            use.studentname = "abdullah";
            use.studentregno = "123.44";
            use.studenthouseno = 44;
            use.postercode = "2233";
            me london=new me();

            london.first = "md";
            london.secound = "fahim";
            london.third = "khan";

           // london.use
           
            london.wwe =use;

            use.pop = london;
            //london =me
            //wwe=me
            //use=address
            //me.address=address
            string ooo = london.wwe.studentregno;
            Console.WriteLine(ooo);

            address rrr = london.wwe;//eita na dileo hoy


            string fool = use.pop.all();
            Console.Write(fool);











          //  int house = use.studenthouseno;
            //  int house = london.wwe.studenthouseno;
            //Console.WriteLine(house);
            Console.ReadKey();

            //address=me.address


        }
    }
}
