using System;

namespace StructEnumHard
{
    class MainClass
    {
        struct Employee
        {
            public int EmpId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Employee(int empid, string fname, string lname)
            {
                EmpId = empid;
                FirstName = fname;
                LastName = lname;
            }

            public string GetFullName()
            {
                return FirstName + " " + LastName;
            }
        }
        public static void Main(string[] args)
        {

            Employee emp = new Employee(10, "Bill", "Gates");

            Console.Write(emp.GetFullName());
        }
    }
}
