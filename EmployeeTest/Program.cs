using System;

namespace EmployeeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Prince", "Bassey", (decimal)5000);
            Employee employee2 = new Employee("James", "Stuart", (decimal)3000);

            Console.WriteLine("Employee1 First Name: {0}", employee1.FirstName);
            Console.WriteLine("Employee1 Last Name: {0}", employee1.LastName);
            Console.WriteLine("Employee1 Salary: {0:C}", employee1.Salary);

            Console.WriteLine("Employee2 First Name: {0}", employee2.FirstName);
            Console.WriteLine("Employee2 Last Name: {0}", employee2.LastName);
            Console.WriteLine("Employee2 Salary: {0:C}", employee2.Salary);

            Console.ReadLine();
            Console.WriteLine("After 10% raise");

            employee1.Salary = employee1.Salary * (decimal)1.1;
            employee2.Salary = employee2.Salary * (decimal)1.1;
            Console.WriteLine("Employee1 new salary: {0:C}", employee1.Salary);
            Console.WriteLine("Employee2 new salary: {0:C}", employee2.Salary);

            Console.ReadLine();
        }
    }
}
