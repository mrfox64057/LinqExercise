using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            //Console.WriteLine(numbers.Sum());
            //Console.WriteLine();
            //Console.ReadLine();
            ////TODO: Print the Average of numbers

            //Console.WriteLine(numbers.Average());
            //Console.WriteLine();
            //Console.ReadLine();

            //TODO: Order numbers in ascending order and print to the console
            //var ascending = numbers.OrderBy(a => a);

            //foreach (var numbers in ascending)
            //{
            //    Console.WriteLine(numbers);
            //}
            //Console.WriteLine();
            //Console.ReadLine();

        //TODO: Order numbers in decsending order and print to the console

        var descending = numbers.OrderByDescending(a => a);

            foreach (var number in descending) 
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            //Console.ReadLine();

            //TODO: Print to the console only the numbers greater than 6

            //numbers.Where(c => c > 6).ToList().ForEach(c => Console.WriteLine(c));
            //Console.WriteLine();
            //Console.ReadLine();

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            //var fourNums = numbers.OrderBy(d => d).Take(4);
            //foreach (var number in fourNums)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine();
            //Console.ReadLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            numbers.SetValue(33, 4);
            Console.WriteLine();
            foreach (var number in descending)
            {
                Console.WriteLine(number);
            }


            // List of employees ****Do not remove this****
            List<Employee> employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their
            //FirstName starts with a C OR an S  //and order this in ascending order by FirstName.
            Console.WriteLine("\n" +
                "\n" +
                "\n" +
                "");
            var filteredEmployees = employees.Where(f => f.FirstName[0] == 'C' || f.FirstName[0] == 'S');
            var alphabetical = filteredEmployees.OrderBy(f => f.FirstName);
            foreach (var employee in alphabetical) 
            {
                Console.WriteLine(employee.FirstName);
            }
            Console.WriteLine("\n" +
                "\n" +
                "");

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console
            //and order this by Age first and then by FirstName in the same result.

            var filtered = employees.Where(a => a.Age > 26).OrderBy(a =>  a.Age).ThenBy(a => a.FirstName);
            foreach (var employee in filtered)
            {
                Console.WriteLine(employee.FullName);
                Console.WriteLine(employee.Age);
                Console.WriteLine();
            }
            Console.WriteLine();
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE
            //is less than or equal to 10 AND Age is greater than 35.

            var years = employees.Where(a => a.YearsOfExperience <= 10 && a.Age > 35).Sum(a => a.YearsOfExperience);
            Console.WriteLine(years);
            var avg = employees.Where(a => a.Age > 35 && a.YearsOfExperience < 10).Average(a => a.YearsOfExperience);
            Console.WriteLine(avg);
            //TODO: Add an employee to the end of the list without using employees.Add()

            var newGuy = new Employee()
            {
                YearsOfExperience = 50,
                FirstName = "Doug",
                LastName = "McEmployee",
                Age = 18,
            };
            employees.Append(newGuy).ToList().ForEach(a=> Console.WriteLine(a.FullName));
            Console.WriteLine();
            
            
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
