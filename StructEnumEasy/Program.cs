using System;

namespace StructEnumEasy
{
    enum WeekDays
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6
    }

    struct Employee
    {
        public int EmpId;
        public string FirstName;
        public string LastName;

        public Employee(int empid, string fname, string lname)
        {
            EmpId = empid;
            FirstName = fname;
            LastName = lname;
        }
    }
    class MainClass
    {
    



        public static void Main(string[] args)
        {
            Employee emp = new Employee(10, "Akshay", "Srikumar");

            Console.Write(emp.EmpId);
            Console.Write(emp.FirstName);
            Console.Write(emp.LastName);
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Friday);


        }
    }
}