using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_condition
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 10;
                string myResult = myVar > 5 ? "great than 5" : "less than 5";
            Console.WriteLine("My Result is {0}", myResult);



            string myName = "Amr" , result ;
            result = (myName.Equals("Amr")) ? "Yes" : "No";
            Console.WriteLine("My Vaiable is {0}", result);
                
            Console.ReadKey();

        }

    }
}
