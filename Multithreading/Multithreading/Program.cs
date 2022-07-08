using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        static void Function1()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Function 1 executed " + i.ToString());
                //Wait for 4 seconds
                Thread.Sleep(4000);
            }
        }
        static void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 2 executed " + i.ToString());
                //Wait for 4 seconds
                Thread.Sleep(4000);
               
            }

        }
        static void Main(string[] args)
        {
            //Created 2 threads
            Thread obj1 = new Thread(Function1);
            Thread obj2 = new Thread(Function2);

            //invoked these threads
            obj1.Start();
            obj2.Start();

            //example for process
            // instantiate a Process object called notePad
            Process notepad = new Process();
            notepad.StartInfo.FileName = "notepad.exe";
            notepad.StartInfo.Arguments = "csharp.cs";
            notepad.Start();
            Console.Read();
            //SearchGoogle("http://www.c-sharpcorner.com/");
            Console.ReadLine();

        }
    }
}
