using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleAppAssign2
{
    public class Configuration
    {
        //Assignment 14: Initializing Configuration with Static Constructor
        //Problem Statement: Create a class Configuration to load system-wide settings(e.g., application
        //name) using a static constructor.Allow individual users to set preferences using an instance
        //constructor.

        //system wide settings
        public static string Application_name;
        public static string Application_version;

        //user unique settings
        public string User_Name;
        public string User_OS;

        static Configuration()
        {
            Application_name = "Dell";
            Application_version = "Inspiron 13 7000 2-in-1";

        }

        public  Configuration(string name, string os)
        {
            User_Name = name;
            User_OS = os;
        }

        public void Print()
        {
            Console.WriteLine($"/{Application_name}/ of model: /{Application_version}/ used by /{User_Name}/, running on /{User_OS}/ OS.");
        }





    }
}
