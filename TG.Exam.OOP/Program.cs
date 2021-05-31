using System;
using System.Collections.Generic;

namespace TG.Exam.OOP
{
    class s
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            s s = new s();
            s.ToString();
            var objs = GetObjects();

            objs.ForEach(o =>
            {
                Console.WriteLine("Object:\r\n{0}", o.ToString2());
            });

            Console.ReadKey();
        }

        private static List<dynamic> GetObjects()
        {
            var objs = new List<dynamic>
            {
                new Employee 
                {
                    FirstName = "Employee1FN",
                    LastName = "Employee1LN",
                    Salary = 5000
                },
                new SalesManager
                {
                    FirstName = "SalesManager1FN",
                    LastName = "SalesManager1LN",
                    Salary = 8000
                },
                new CustomerServiceAgent
                {
                    FirstName = "Developer1FN",
                    LastName = "Developer1LN",
                    Salary = 12000
                },
                new Dog
                {
                    Age = 2,
                    Name = "Dog1N"
                },
            };

            return objs;
        }
    }
}
