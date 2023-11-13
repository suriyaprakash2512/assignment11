using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Salary Calculation System!");

            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Developer");

            int employeeType = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter working hours:");
            int workingHours = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of working days:");
            int workingDays = int.Parse(Console.ReadLine());

            int projectHandles = 0;
            int extras = 0;

            if (employeeType == 2) // Admin
            {
                Console.WriteLine("Enter number of project handles:");
                projectHandles = int.Parse(Console.ReadLine());
            }
            else if (employeeType == 3) // Developer
            {
                Console.WriteLine("Enter extra hours:");
                extras = int.Parse(Console.ReadLine());
            }

            double monthlySalary = CalculateSalary(workingHours, workingDays, projectHandles, extras);

            Console.WriteLine($"Monthly Salary: {monthlySalary:C}");
            Console.ReadKey();
        }

        static double CalculateSalary(int wHour, int nWDays, int projectHandles = 0, int extras = 0)
        {
            double salary = wHour * nWDays * 100 + projectHandles * 3000 + extras * 2;
            return salary;
        }

    }

}