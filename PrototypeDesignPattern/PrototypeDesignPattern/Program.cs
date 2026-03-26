using System;
namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new PermanentEmployee()
            {
                Name = "Anurag",
                Department = "IT",
                Type = "Permanent",
                Salary = 100000
            };

            Employee emp2 = emp1.GetClone();

            emp2.Name = "Pranaya";
            emp2.Department = "HR";
            emp1.ShowDetails();
            emp2.ShowDetails();

            Employee emp3 = new TemporaryEmployee()
            {
                Name = "Preety",
                Department = "HR",
                Type = "Temporary",
                FixedAmount = 200000
            };

            Employee emp4 = emp3.GetClone();

            emp4.Name = "Priyanka";
            emp4.Department = "Sales";
            emp3.ShowDetails();
            emp4.ShowDetails();
            
            Console.Read();
        }
    }
}