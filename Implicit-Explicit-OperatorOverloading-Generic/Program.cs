﻿using System;
using System.Globalization;

namespace Implicit_Explicit_OperatorOverloading_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region implicit explicit
            ////0 Celsius=32 Fahrenheit
            ////1 Celsius=33.8 Fahrenheit
            ////22 Celsius=71.6 Fahrenheit

            //Celsius C = new Celsius(22);
            //Fahrenheit F = (Fahrenheit)C;

            //Console.WriteLine(F.Degree);
            #endregion

            
            Employee employee1 = new Employee("Aras","Alakbarzade",2016,2000);
            DateTime date1 = DateTime.Now.AddYears();
          
            Employee employee2 = new Employee("Azer","Alakbarzade", 2018,2200);
            
            

            Console.WriteLine(employee1<=employee2);

            Employee[] employees = { employee1, employee2 };

            Array.Sort(employees);
            foreach (var items in employees)
            {
                Console.WriteLine(items);
            }  
        }

    }
    #region implicit explicit
    class Celsius
    {
        public double Degree { get; set; }

        public Celsius(double C)
        {
            Degree = C;
        }
    }


    class Fahrenheit
    {
        public double Degree { get; set; }

        public Fahrenheit(double F)
        {
            Degree = F;
        }

        public static implicit operator Fahrenheit(Celsius C)
        {
            return new Fahrenheit(C.Degree * 1.8 + 32);
        }
    }
    #endregion







}
