using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_class
{
    public class Taiwaneese : Employee
    {
        public string Name { get; set; }

        public Taiwaneese(string name)
        {
            this.Name = name;
        }

        public int Age { get; set; }


        public string Nationailty
        {
            get { return "中華台北"; }
        }


        public bool Hire()
        {
            int age = this.Age;

            if (Name.StartsWith("C"))
            {
                if (age >= 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (age >= 25)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           
        }
    }
}
