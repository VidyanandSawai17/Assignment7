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
        public double sal, hra, da, pf, pt,total, gross;


        public employe () //constructor
        {
            id = 0;
            name = "";
            sal= 0;
            pt = 200;
            
        }

        public  employe(int id, string name, double sal, double pt)  
        {
            this.id = id;           // this keyword points to the data member
            this.name = name;
            this.sal = sal;
            this.pt = pt;
            
        }

        public void salary()
        {
            hra = sal * 0.40;
            da = sal * 0.20;
            pf = sal * 0.12;
            total = hra+ da + pf + pt ;
            gross = sal - total;

        }

        public string Display()
        {
            return $"\n Roll No : {id} \n Name : {name} \n Salary = {sal} \n Gross salary = {gross} ";
        }

    }
}
