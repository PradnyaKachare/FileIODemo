using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    // [] called Attribute inc#
    [Serializable] //
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }         
    }
}
