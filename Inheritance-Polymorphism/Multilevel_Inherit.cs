using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance
{
    
    public class Cars
    {
        public string Company;
        public Cars(string name)
        {
            this.Company = name;
        }
    }
    public class Owners : Cars
    {
        public string FirstName;


        public Owners(string company,string owner) :base(company) 
        {

            this.FirstName = owner;
        }

        public  void OwnComp(string company,string owner)
        {
            Console.WriteLine(Company + " " + owner);
        }


    }

    public class Features : Owners
    {

        public string Location;

        public Features(string company, string owner, string location) : base(company,owner)
        {

            this.Location = location;
        }
        public void features()
        {
            
            Console.WriteLine("---------");
            Console.WriteLine("Name:Corolla,Model:2017;Colour:Black");
            
        }

    }






}
