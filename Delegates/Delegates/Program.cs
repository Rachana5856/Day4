using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
       
{
    delegate int Calculator(int n);//declaring delegate
    class Program
    {
        static int number = 100;
        public int add(int n)//non static method
        {
            number = number + n;
            return number;
        }
        public static int mul(int n)//Static Method
        {
            number = number * n;
            return number;
        }  

        static void Main(string[] args)
        {
            Program p = new Program();
            Calculator c1 = new Calculator(p.add);//instantiating delegate  
            Calculator c2 = new Calculator(Program.mul);
            int a= c1.Invoke(20);//calling method using delegate  
            Console.WriteLine("After c1 delegate, Number is: " + a);
            int b =c2(3);
            Console.WriteLine("After c2 delegate, Number is: " + b);
            Console.ReadLine();
        }
    }
}
