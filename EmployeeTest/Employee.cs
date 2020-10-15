namespace EmployeeTest
{
    public class Employee
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       private decimal salary;

       // This is my Constructor
       public Employee (string firstName, string lastName, decimal salary)
       {
           this.FirstName = firstName;
           this.LastName = lastName;
           this.Salary = salary;
       }

       public decimal Salary
       {
           get { return salary; }
           set
           {
               if (value >= 0)
               salary = value;
           }
       }
    }
}