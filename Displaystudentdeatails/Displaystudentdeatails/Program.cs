using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Displaystudentdeatails
{
    class Program
    {
        static void Main()
        {
            // File path
            string filePath = @"C:\Users\vadde\source\repos\Displaystudentdeatails\Displaystudentdeatails\students.txt";

            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("student data from a text file");


            foreach (string i in lines)
            {
                Console.WriteLine(i);
            }

        }
    }
}
