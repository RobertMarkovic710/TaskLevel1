using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program         //ctrl + F5
    {
        static void Main(string[] args) 
        {
          Start:
          Console.WriteLine("Please ENLIST or DISPLAY: ");
          String ChooseOperation = (Console.ReadLine().ToLower());

           if (ChooseOperation == "enlist") {
               String[] StudentInfo = new string[3];
               Console.WriteLine("Enter your name, last name and GPA:");

               for (int x = 0; x < 3; x++)
               {
                   StudentInfo[x] = Console.ReadLine();
               }

               StreamWriter SW = new StreamWriter(@"C:\Users\Windows7\Documents\GitHub\TaskLevel1\StudentContainer.txt");

               for (int x = 0; x < 3; x++)
               {
                   SW.WriteLine(StudentInfo[x]);
               }

               SW.Close();
               goto Start;
           }

           else if (ChooseOperation == "display")
           {
               string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Windows7\Documents\GitHub\TaskLevel1\StudentContainer.txt");
               System.Console.WriteLine("Student Container displayed = ");

               foreach (string line in lines)
               {
                   Console.WriteLine(line);
               }

               Console.WriteLine("Press any key to exit.");
               System.Console.ReadKey();
           }

           else {
               Console.WriteLine("Type valid operation");
               goto Start;
           }
        }
    }
}