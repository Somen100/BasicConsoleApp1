using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp1
{
    // for chapter 9,10
    public class Car1
    {
        public static void run()
        {
            Console.WriteLine("I'm Static method");
        }

        //non static method or instanse method
        public void engine()
        {
            Console.WriteLine("I'm non-static/instance method!!!");
        }
    }
}
