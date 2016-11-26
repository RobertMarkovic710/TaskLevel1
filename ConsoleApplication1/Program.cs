using System;
using System.Collections.Generic;
using System.Linq;         //int only numbers, string can do letters and numbers
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program         //ctrl + F5
    {
        static void Main(string[] args)
        {
            //data insert
            String[] StudentInfo = { "StudentName", "StudentLastName", "StudentGPA", }; //variabla StudentInfo

            Console.WriteLine("Please enter your first name: ");
            String StudentName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            String StudentLastName = Console.ReadLine();

            Console.WriteLine("Please enter your GPA: ");
            String StudentGPA = Console.ReadLine();

            
            //writing to text file
            StreamWriter SW = new StreamWriter(@"C:\Users\Windows7\Documents\GitHub\TaskLevel1\StudentContainer.txt");
            //SW.WriteLine(StudentInfo);
            SW.WriteLine(StudentName);
            SW.WriteLine(StudentLastName);
            SW.WriteLine(StudentGPA);
            SW.Close();
        }
    }
}