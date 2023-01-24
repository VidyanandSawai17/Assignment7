using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employe emp = new employe("Vidyanand", 100000);
            employe emp2 = new employe("Vivekanand", 1500000);
            emp.salary();
            Console.WriteLine(emp.Result());
            Console.WriteLine(emp2.Result());


        }
    }
}


/*    In the existing Emp class accept empid, empname from basic salary from the constructor
    
        Calculate salary as below

        HRA 40 % of basic
        Da  20 % of basic
        Pf  12 % of basic
        PT =200

        Calculate the total & net paid salary
        Basic +hra+da → total
        Total - (pf+pt)  → net paid salary */