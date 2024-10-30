using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    public partial class Assign_7
    {
        //Assignment 7. Partial Class
        //Create a partial class Person that is defined in two files.One file should have the property Name,
        //and the other file should have the method ShowDetails()

        public string Name;
        public int Id;
        public string School;
        public string College;
        public string Company;

        public Assign_7(string name, int id, string school, string college, string company)
        {
            Name = name;
            Id = id;
            School = school;
            College = college;
            Company = company;
        }
    }
}
