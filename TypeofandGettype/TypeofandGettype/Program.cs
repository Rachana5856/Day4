using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeofandGettype
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";

            Type t1 = typeof(string);
            Type t2 = s.GetType();
            Console.WriteLine(t1 == t2);
            Console.WriteLine("TypeOf: {0}", typeof(string));

            object obj = "hello";

            Type a1 = typeof(object); // ==> object
            Type a2 = obj.GetType();  // ==> string!
            Console.WriteLine(a1 == a2);
            Console.WriteLine("TypeOf: {0}", typeof(object));
            Console.ReadLine();
        }
    }
}
