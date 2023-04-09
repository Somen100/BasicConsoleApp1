using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp1
{
    public class Add
    {
        int x; int y;
        double d; string s;

        //   1st constructor 
        public Add(int a, int b)
        {
            x = a; y = b;
        }

        //   2nd constructor 
        public Add(int a, double b)
        {
            x = a; d = b;
        }

        //   3rd constructor 
        public Add(int a, string b)
        {
            x = a; s = b;
        }

        // showing 1st constructor's result
        public void show1()
        {
            Console.WriteLine("1st constructor (int + float): {0} ",
                                                           (x + y));
        }

        // shows 2nd constructor's result
        public void show2()
        {
            Console.WriteLine("2nd constructor (int + double): {0}",
                                                           (x + d));
        }

        // shows 3rd constructor's result
        public void show3()
        {
            Console.WriteLine("2nd constructor (int + string): {0}",
                                                           (x + s));
        }
    }
}
