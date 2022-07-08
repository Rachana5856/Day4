using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsandAs
{
    class Program
    {
        static void Main(string[] args)
        {
            object str1 = "Madam";
            if (str1 is string)         //checking type using is keyword
            {
                Console.WriteLine("yes it is a string");
                //Console.ReadLine();
            }  
            ///------Converting object to string using AS keyword

            object str11 = "Madam";
            string str2 = str11 as string;
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}
