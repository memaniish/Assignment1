﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Empolyee Wage Computation Program");
            //EmpAttendance empattendance = new EmpAttendance();
            EmpAttendance.GetMonthlyEmpWage();
            Console.ReadLine();
        }
    }
}
