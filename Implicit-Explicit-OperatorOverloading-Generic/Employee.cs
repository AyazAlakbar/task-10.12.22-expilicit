using System;
using System.Collections.Generic;
using System.Text;

namespace Implicit_Explicit_OperatorOverloading_Generic
{
    internal class Employee:IComparable
    {
      
        public Employee() { 
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public int Salary { get; set; }


        public Employee(string name, string surname, DateTime birthday, int salary)
        {
        Name = name;
        Surname = surname;
        BirthDay = birthday;
        Salary = salary;

        }


        



        public static bool operator >=(Employee emp1, Employee emp2)
        {
            return emp1.BirthDay >= emp2.BirthDay;

        }

        public static bool operator <=(Employee emp1, Employee emp2)
        {
            return emp1.BirthDay <= emp2.BirthDay;

        }

        public int CompareTo(object obj)
        {
            return this.BirthDay.CompareTo(((Employee)obj).BirthDay);
        }
    }

    
}
