using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_class
{
    public interface Employee
    {
        string Name { get; set; }
        int Age { get; set; }
        string Nationailty { get; }
        bool Hire();
    }
}
