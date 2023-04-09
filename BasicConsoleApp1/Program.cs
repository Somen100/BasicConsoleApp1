using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Chapter 1.Basics ***************************************************
            Console.WriteLine("Chapter 1.Basics");
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
            


            Console.WriteLine("***********");

            //Chapter 2. Reading and Writing Console ***************************************************
            Console.WriteLine("Chapter 2. Reading and Writing Console ***************************************************");

            Console.WriteLine($"1st answer:");
            string EmplName = "Somen Singh";

            Console.WriteLine("*********");

            Console.WriteLine($"{EmplName}");
            Console.WriteLine($"\n 2nd answer:");
            string SchoolName = "Holy Cross School";
            Console.WriteLine($"School name is {SchoolName}");

            Console.WriteLine("*********");

            Console.WriteLine($"\n 3rd answer:");
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");

            Console.WriteLine("*********");
            Console.WriteLine($"\n 4th answer: concatenation: ");
            Console.WriteLine("Enter first name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lname = Console.ReadLine();
            Console.WriteLine($"Hello {fname} {lname}!");

            Console.WriteLine("*********");

            Console.WriteLine($"\n 5th answer) Write a program by taking two integer values and return the value by adding i: ");
            Console.WriteLine("Enter 1st integer");
           int i1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd integer");
            int i2 = int.Parse(Console.ReadLine());
            int i3 = i1 + i2;
            Console.WriteLine($"{i1}+{i2} = {i3}");


            Console.WriteLine($"\n 6th answer)Write a program to enter password by converting it to char array into string print theOutput ");
            Console.Write("Enter password");
            string pswd = Console.ReadLine();
            char[] pswdArray = pswd.ToCharArray();

            for (int a = 0; a < pswdArray.Length; a++)
            {
                Console.WriteLine("your password is : " + pswdArray[a]);
            }

            Console.WriteLine("  ");

            //Chapter 3.Built In Data Types ***************************************************
            Console.WriteLine("Chapter 3. Built In Data Types ***************************************************");
            Console.WriteLine("1st Q");
            int noOfContainers = 80;
            Console.WriteLine(noOfContainers + "\n");

            Console.WriteLine("2nd Q");
            bool pass = true;
            Console.WriteLine(pass + "\n");

            Console.WriteLine("3rd Q");
            Console.WriteLine("Enter a float value");
            float floatvalue = float.Parse(Console.ReadLine());
            Console.WriteLine("The float number is " + floatvalue + "\n");

            Console.WriteLine("4th Q: + - * /");
            float numb1, numb2, output; char sign;
            Console.WriteLine("Enter 1st value");
            numb1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd value");
            numb2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Select anyone operator from keyboard: + , - , * , + ");
            sign = char.Parse(Console.ReadLine());

            switch (sign)
            {

                case '+':
                    output = numb1 + numb2;
                    Console.WriteLine($"Sum: {output}");
                    break;

                case '-':
                    output = numb1-numb2;
                    Console.WriteLine($"Difference: {output}");
                    break;

                case '*':
                    output = numb1 * numb2;
                    Console.WriteLine($"Product: {output}");
                    break;

                case '/':
                    if (numb2 == 0)
                    {
                        Console.WriteLine("Please enter not null divisor");
                        break;
                    }

                    output = numb1 / numb2;
                    Console.WriteLine($"Quotient: {output}");
                    break;
            }
            Console.WriteLine("5th Q:Revere a 3 letters string");

            Console.WriteLine("Enter 1st character");
            char charr1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd character");
            char charr2 = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd character");
            char charr3 = char.Parse(Console.ReadLine());


            Console.WriteLine($"Reverse output of {charr1}{charr2}{charr3} is {charr3}{charr2}{charr1}");
            Console.WriteLine("*************");

            Console.WriteLine("6th Q: Check the input character");

            Console.WriteLine("Enter the character");
            char char4 = char.Parse(Console.ReadLine());
            bool numCheck = Char.IsNumber(char4);
            if (numCheck)
            {
                Console.WriteLine($"{numCheck} is a number");

            }

            bool letterCheck = Char.IsLetter(char4);
            if (letterCheck)
            {
                Console.WriteLine($"{char4} is a letter");

            }


            bool lowerCheck = Char.IsLower(char4);
            if (lowerCheck)
            {
                Console.WriteLine($"{char4} is a lower case letter");
            }


            bool upperCheck = Char.IsUpper(char4);
            if (upperCheck)
            {
                Console.WriteLine($"{char4} is an upper case letter");
            }

            Console.WriteLine("***********");

            //Chapter 4.String Data Type ***************************************************
            Console.WriteLine("Chapter 4.String Data Type ***************************************************");

            // Console.WriteLine("Reverse a string ");
            Console.WriteLine("***************1st Qn:Reverse a string");
            Console.WriteLine("Enter your string");

            string word = Console.ReadLine();
            char[] charArray = word.ToCharArray();
            for (int a = charArray.Length; a > 0; a--)
            {
                Console.Write(charArray[a - 1]);
            }


            // Console.WriteLine("find length of a string");

            Console.WriteLine(" *************** 2nd qn: find length of a string");
            Console.WriteLine("Enter your string");
            string word2 = Console.ReadLine();
            int count = 0;
            foreach (char w in word2)
            {
                count++;
            }
            Console.WriteLine(count);

            // Console.WriteLine("find length of a string using count function");
            Console.WriteLine(" *************** 3rd qn: find length of a string using count function");
            Console.WriteLine("Enter your string");
            string word3 = Console.ReadLine();
            int count2 = 0;
            count2 = word3.Count();
            Console.WriteLine("length using count function: " + count2);

            // Console.WriteLine(" Replace a string");
            Console.WriteLine(" *************** 4th qn: Replace a string");

            string word4 = "Sun Rises in the West  ";
            Console.WriteLine(word4 + "/n");
            string replacedWord = word4.Replace("West", "East");

            Console.WriteLine("Replaced string: " + replacedWord);

            // Console.WriteLine("UpperCase to  Lowercase");
            Console.WriteLine("*************** 5th qn:UpperCase to  Lowercase");
            Console.WriteLine("Enter a string in Uppercase");
            string ucaseWord = Console.ReadLine();
            string lcaseWord = ucaseWord.ToLower();

            Console.WriteLine("lowercase string: " + lcaseWord);

            // Console.WriteLine("Find maximum occuring character in a string");
            Console.WriteLine("*************** 7th qn: sort a string array in ascending order.");
            Console.WriteLine("Enter a string to sort in ascending order");
            string str1 = Console.ReadLine();
            char[] spearator = { ',', ' ' };
            string[] names = str1.Split(spearator);

            Array.Sort(names);
            foreach (string nm in names)
            {
                Console.WriteLine(nm);
            }

            Console.WriteLine("***********");

            //Chapter 5.Operators ***************************************************
            Console.WriteLine("Chapter 5.Operators ***************************************************");


            Console.WriteLine("qn1: Binary opr");
            Console.WriteLine("Enter first number");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator symbol");
            char opr = char.Parse(Console.ReadLine());
            float reslt;
            switch (opr)
            {
                case '+':
                    reslt = num1 + num2;
                    break;
                case '-':
                    reslt = num1 - num2;
                    break;
                case '*':
                    reslt = num1 * num2;
                    break;
                case '/':
                    reslt = num1 / num2;
                    break;
                case '%':
                    reslt = num1 % num2;
                    break;
                default:
                    reslt = 0;
                    break;

            }
            Console.WriteLine("result:" + reslt + "\n");



            Console.WriteLine("qn2: Unary Opr");
            Console.WriteLine("Enter the number");
            float num3 = float.Parse(Console.ReadLine());
            Console.WriteLine($"a is {num3} and result for  a++ is " + num3++);
            Console.WriteLine($"a is {num3} and result for  a-- is " + num3--);
            Console.WriteLine($"a is {num3} and result for  ++a is " + ++num3);
            Console.WriteLine($"a is {num3} and result for  --a is " + --num3);
            Console.WriteLine("****\n");

            Console.WriteLine("qn3: Relational Opr");
            Console.WriteLine("Enter first number");
            float num4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            float num5 = float.Parse(Console.ReadLine());

            Console.Write("result for  Equal to Operator is :");
            Console.WriteLine(num4 == num5);
            Console.Write("result for  Greater than Operator is  :");

            Console.WriteLine(num4 > num5);


            Console.WriteLine($" result for  Less than Operator is ");
            Console.WriteLine(num4 < num5);


            Console.WriteLine($"result for Greater than or Equal to Operator: is ");
            Console.WriteLine(num4 >= num5);


            Console.WriteLine($"result for Lesser than or Equal to Operator: is ");

            Console.WriteLine(num4 <= num5);


            Console.WriteLine("***********");

            //Chapter 6. Datatype Conversions ***************************************************
            Console.WriteLine("Chapter 6. Datatype Conversions ***************************************************");


            Console.WriteLine("1) Implicit type conversion");
            Console.WriteLine("Enter Int value");
            int number1 = int.Parse(Console.ReadLine());
            double number2 = num1;
            Console.WriteLine("Implicitely converted from int to double: " + number1);

            Console.WriteLine("2) Explicit type conversion");
            Console.WriteLine("Enter double value");
            double number3 = double.Parse(Console.ReadLine());
            int number4 = (int)number3;
            Console.WriteLine("Explicitly converted from double to int: " + number4);

            Console.WriteLine("3) String to Integer");
            Console.WriteLine("Enter a numeric string value");
            string number5 = Console.ReadLine();

            int number6 = int.Parse(number5);

            Console.WriteLine("Explicitly converted from string to int: " + number6);

            Console.WriteLine("4) Integer to string");
            Console.WriteLine("Enter a float value");

            float number7 = float.Parse(Console.ReadLine());

            string number8 = number7.ToString();

            Console.WriteLine("Explicitly converted from float to string: " + number8);


            Console.WriteLine("***********");

            //Chapter 7. IF statement ***************************************************
            Console.WriteLine("Chapter 7. IF statement ***************************************************");

            Console.WriteLine("1) Write a C# Sharp program to check whether a given number is positive or negative.");

            Console.WriteLine("Enter Int value");
            int a1 = int.Parse(Console.ReadLine());
            if (a1 > 0)
            {
                Console.WriteLine($"{a1} is positive");
            }
            else if (a1 < 0)
            {
                Console.WriteLine($"{a1} is negative");

            }
            else
            {
                Console.WriteLine($"{a1} is 0");
            }

            Console.WriteLine("\n 2) Write a C# Sharp program to find whether a given year is a leap year or not. \n");
            Console.Write("Input an year : ");
            int chk_year = Convert.ToInt32(Console.ReadLine());

            if ((chk_year % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", chk_year);
            else if ((chk_year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", chk_year);
            else if ((chk_year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", chk_year);
            else
                Console.WriteLine("{0} is not a leap year.\n", chk_year);


            Console.WriteLine("\n 3) Write a C# Sharp program to check whether an alphabet is a vowel or consonant. \n");
            Console.Write("Input an Alphabet (A-Z or a-z) : ");

            char ch;
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.Write("You entered a number, Please enter an alpahbet.");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is not a vowel");
                        break;
                }

            }



            Console.WriteLine("***********");

            //Chapter 8. IF statement ***************************************************
            Console.WriteLine("Chapter 8.For & Foreach Loop ***************************************************");

            Console.WriteLine("Q.1 Sum of n natural numbers");
            Console.WriteLine("Q.1  How many natural numbers do you want to sum");
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int a = 1; a<= input; a++)
            {
                sum = sum + a;
            }
            Console.WriteLine($"Sum of {input} natural nos is: " + sum + "\n\n");
            Console.WriteLine("Q.2.Write a program in C# Sharp to display the n terms of odd natural number and their sum.");
            int j, sum1 = 0, n;
            Console.Write("Enter the Nth Number : ");
            n = int.Parse(Console.ReadLine());
            for (j = 0; j <= 2 * n; j++)
            {
                if (j % 2 != 0)
                {
                    sum1 = sum1 + j;
                }

            }
            Console.WriteLine("\nSum of N Numbers : " + sum1 + "\n\n");


            Console.WriteLine("Q.3. Enter Array printing using ForEach loop.");


            string[] strArray = new string[] { "abc", "def", "asd" };
            //Console.Write("Printing an array of strings by taking input from user : ");
            //strArray.ToList().ForEach(Console.WriteLine);

            Console.Write("Printing an array of strings by taking input from user : ");
            Console.Write("Enter the strings : ");
            string[] stringList = (Console.ReadLine()).Split(' ').ToArray();
            foreach (var inp in stringList)
            {
                Console.Write(inp + ",");
            }
            Console.WriteLine("************************");
            Console.WriteLine("Q.3.Enter Array printing using for loop.");


            string[] strArray2 = new string[] { "abc", "def", "asd" };
            Console.Write("Printing an array of strings by taking input from user : ");
            strArray2.ToList().ForEach(Console.WriteLine);

            Console.Write("Printing an array of strings by taking input from user : ");
            Console.Write("Enter the strings : ");
            string[] stringList2 = (Console.ReadLine()).Split(' ').ToArray();
            foreach (var m in stringList2)
            {
                Console.Write(m + ",");
            }

            Console.WriteLine("***********");

            //Chapter Chapter 9 & 10.Methods  ***************************************************
            Console.WriteLine("Chapter 9 & 10.Methods ***************************************************");

            //Q.1) Write a program using WriteLine(Boolean) method in c#
            Console.WriteLine("Q.1) Write a program using WriteLine(Boolean) method in c#");
            bool eligibleVoter;
            Console.Write("Whats your age :  ");
            int age = int.Parse(Console.ReadLine());


            if (age >= 18)
                eligibleVoter = true;
            else
                eligibleVoter = false;
            Console.Write("Are you an EligibleVoter: true/false: " + eligibleVoter + "\n\n");

            Console.WriteLine("*****************************");


            //Q.2)Write a program on static and instance methods in c#"
            Console.WriteLine("Q.2)Write a program on static and instance methods in c#");
            //Call static method by class name 
            Car1.run();

            //Call non-static method. call method by object
            Car1 c = new Car1();
            c.engine();

            Console.WriteLine("*****************************");
            //Q.3)Write a method of Calculator and print sum and product in c#
            Console.WriteLine("Q.3)Write a method of Calculator and print sum and product in c#");
            Calculator calc = new Calculator();

            Console.WriteLine("enter a and b values BY PRESSING IN BETWEEN THE 2 NOS");
            double sumResult = 0, productResult = 1;
            double[] numbers = Console.ReadLine().Split(' ').Select(item => double.Parse(item)).ToArray();

            sumResult = calc.Sum(numbers);
            productResult = calc.Product(numbers);
            Console.WriteLine($"sum = {sumResult} and product = {productResult}");


            //Q.4)Write a program using parameter arrays and print output in console in c#
            Console.WriteLine("Q.4)Write a program using parameter arrays and print output in console in c#");
            Console.WriteLine("enter array values");
            string[] arryvalues = Console.ReadLine().Split(' ').ToArray();
            foreach (var arry in arryvalues)
            {
                Console.Write(arry + " ");
            }

            //Q.5)Write a program to print entered number of even numbers in c#
            Console.WriteLine("Q.5)Write a program to print entered number of even numbers in c#");
            Console.WriteLine("Q.5)How many even no you want to add ?");

            int no = int.Parse(Console.ReadLine());
            int answer = numbersMethod(no);
            Console.WriteLine($"The sum of {no} even integers = {answer}");



            Console.WriteLine("***********");

            //Chapter Chapter 11.Class - Introduction***************************************************
            Console.WriteLine("Chapter 11.Class - Introduction***************************************************");
            Console.WriteLine("Q.1) Construct a class using any methods for employee details using its parameters and print Output.");
            Employee employee = new Employee()
            {
                Name = "Star Player",
                City = "Banglore",
            };
            //employee.Name = "Somen Singh ";
            //employee.City = "Bokaro Steel City";
            employee.PrintEmployeeDetails(employee);

            //Q.2) Write a program using overloading class constructor.
            // Its class is defined below the Main class.

            Console.WriteLine("Q.2) Write a program using overloading class constructor");

            Add add1 = new Add(5, 10);
            add1.show1();
            Add add2 = new Add(5, 10.5);
            add2.show2();
            Add add3 = new Add(5, "Ok");
            add3.show3();


            Console.WriteLine();
            //Q.3) Create a Car class with three class members and two fields and one method.
            // Its class is defined below the Main class.
            Console.WriteLine("Q.3)  Create a Car class with three class members and two fields and one method in c#");
            Car car = new Car(50, "black", 200);
            car.PrintCarDetails(car);
            Console.WriteLine("***********");
            car.accelerate(5.7);

            //Q.4) Create an object of the Car class, with the name myObj.Then we print the value of
            //the fields color and maxSpeed..
            // Its class is defined below the Main class.
            Console.WriteLine("Q.4)  Create an object of the Car class, with the name myObj.Then we print the value of the fields color and maxSpeed.");

            car.PrintCarMaxSpeed(car);


            //Q.5 Write a program on creating multiple objects of one class in c#
            Console.WriteLine("Q.5) Write a program on creating multiple objects of one class in c#.");

            BgColor myObj1 = new BgColor();
            BgColor myObj2 = new BgColor();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
            

            // Chapter 12.Static & Instance Members ***************************************************

            // Q2 Define a static method and access that through a instance

            Console.WriteLine("Chapter 12.Static & Instance Members");

            // Q1.Define a static variable and access that through class name.
            Console.WriteLine("Define a static variable and access that through class name \n");

            Console.WriteLine("Static variable: "+ TemperatureConverter.dayno+"\n");

            Console.WriteLine("Q.1 and Q.2) Define a static variable  and static method and access that through class name");
            Console.WriteLine("Please enter the Celsius temperature: ");
            double C = double.Parse(Console.ReadLine()) ;
            double F = TemperatureConverter.CelsiusToFahrenheit(C);
            Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);


            Console.Write("Please enter the Fahrenheit temperature: ");
            double F1 = double.Parse(Console.ReadLine());
            double C1 = TemperatureConverter.FahrenheitToCelsius(F1);
            Console.WriteLine("Temperature in Fahrenheit: {0:F2}", C1);

            Console.WriteLine("***********");
            // Q3 Define a static and instance variable constructors and invoke the instance constructor 
            Console.WriteLine("Q3 Define a static and instance variable constructors and invoke the instance constructor ");

            int dayno = TemperatureConverter.dayno;
            Console.WriteLine("Invoking static class- static contructor: "+ dayno);

            // Q4 Define a static variable and change within the class 
            Console.WriteLine("Q4 Define a static variable and change within the class ");
            TemperatureConverter.marks= 90;
            Console.WriteLine("Invoking static class variable with changed value, MARKS: " + TemperatureConverter.marks);
            Console.ReadLine();
        }


        // for chapter 9 and 10
        public static int numbersMethod(int x)
        {
            int sumValue = 0;
            for (int i = 1; i <= 2 * x; i++)
            {
                if (i % 2 == 0)
                    sumValue += i;
            }
            return sumValue;
        }
    }
}
