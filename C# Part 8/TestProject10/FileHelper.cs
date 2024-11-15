using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject10
{
    public class FileHelper
    {
        //10. NUnit Test for File Validation
        //Question:
        //Write a program with a FileHelper class containing a method IsValidFile(string filePath) that
        //returns true if the file exists and is less than 1 MB.Use NUnit to test this method for cases
        //where:
        // The file exists and is under 1 MB.
        // The file does not exist.
        // The file exists but is over 1 MB.
        public bool IsValidFile(string filepath)
        {
            FileInfo fileInfo = new FileInfo(filepath);
            if (fileInfo.Exists && fileInfo.Length < 1024 * 1024)
            {
                return true;
            }
            return false;
        } 
    }
}
