using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public void PrintEmployeeDetails(Employee emp)
        {
            Console.WriteLine($"Name: {emp.Name} and City: {emp.City}");
        }
    }
}
