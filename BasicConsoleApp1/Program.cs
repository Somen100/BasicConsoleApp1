using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1st task: Declaring a variable of type int");
            int EmpID;
            
            Console.WriteLine(" 2nd task: Declaring a variable of type string");
            string EmpName;

            Console.WriteLine(" 3rd task: Assigning a value to the variable of type int \n");
            EmpID = 5;
            Console.WriteLine(EmpID);
            Console.WriteLine(" 4th task: Assigning a value to the variable of type string \n");
            EmpName = "Puja";
            Console.WriteLine(EmpName);
            Console.WriteLine("***********");


            Console.WriteLine("5th task: Even Odd Test Program \n");
            Console.WriteLine("Enter your number");
            string result;
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                result = "even";
            }
            else
            {
                result = "odd";
            }
            Console.WriteLine($"{num} is {result}");
           

            Console.WriteLine("***********");


            Console.WriteLine("6th task: Swap 2 numbers \n");
            Console.WriteLine("Enter 1st number");
            int swapNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int swapNum2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The numbers are: 1stNum:{swapNum1} and 2ndNum:{swapNum2}");
            Console.WriteLine("Lets Swap the 2 numbers ?\n");
            Console.WriteLine($"1stNum : {swapNum2} and 2ndNum: {swapNum1}");
            Console.Read();


            Console.WriteLine("***********");


            Console.WriteLine("7th task: Swap 2 numbers \n");
        }
    }
}
