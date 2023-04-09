using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp1
{ 
     // for chapter 9,10
    public class Calculator
    {
        public double Sum(double[] arr)
        {
            double sum = 0.0;
            foreach (double num in arr)
            {
                sum += num;
            }
            return sum;
        }
        public double Product(double[] arr)
        {
            double product = 1;
            foreach (double num in arr)
            {
                product *= num;
            }
            return product;
        }
    }
}
