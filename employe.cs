using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{

    

    public class employe  // variables, constructor,method,property,indexer,event
    {
        public int id;
        public string name;
        public double sal, hra, da, ta, gross, pf,pt;
        private static int count;


        public employe () // default constructor
        {
            id = 0;
            name = "";
            sal= 0;
            pt = 200;
            
        }


        // parameterized constructor would

        // initialized data members with

        // the values of passed arguments

        // while object of that class created.
        public employe(string name, double sal)
        {
            // this keyword points to the data member
            count++;
            id = count;
            this.name = name;
            this.sal = sal;

        }

        public void salary()
        {
            hra = sal * 0.40;
            da = sal * 0.20;
            ta = sal * 0.10;
            pf = sal * 0.12;
            gross = (sal + hra + da + ta) - pf;


        }

        public string Result()
        {
            return $"\n Id ={id} \n Name ={name} \n Basic Salary ={sal} \n Gross of Employee ={gross}";

        }

    }
}
