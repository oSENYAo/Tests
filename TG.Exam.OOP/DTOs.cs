using Salestech.Exam.OOP.Interfaces;

namespace TG.Exam.OOP
{

    public class Employee : IString
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public virtual string ToString2()
        {
            return "Employee: " + FirstName + " " + LastName + " " + Salary;
        }
    }

    public class SalesManager : Employee, IString 
    {
        public int BonusPerSale { get; set; }
        public int SalesThisMonth { get; set; }
        public override string ToString2()
        {
            return "SalesManager: " + BonusPerSale + " " + SalesThisMonth;
        }
    }

    public class CustomerServiceAgent : Employee, IString
    {
        public int Customers { get; set; }
        public override string ToString2()
        {
            return "CustomerServiceAgent: " + Customers;
        }
    }

    public class Dog : IString
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string ToString2()
        {
            return "Dog: " + Name + " " + Age;
        }
    }
}
