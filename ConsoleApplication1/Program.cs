using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
            {
                Console.WriteLine("Please ENLIST or DISPLAY: ");
                chooseOperation();
            }

        Student newStudent = new Student();      // makljaza sa klassama
        newStudent.studentFirstName = ;

        Operations newOperations = new Operations();

        public static void chooseOperation()
        {
            string userWish = (Console.ReadLine().ToLower());
            if (userWish == "enlist")
            {
                enlistOperation();
            }
            else if (userWish == "display")
            {
                displayOperation();
            }
            else
            {
                invalidOperation();
            }
        }

        static void enlistOperation()
            {
                String[] StudentInfo = new string[3];  //new string [2]
                Console.WriteLine("Enter your name, last name and GPA:");  //student klasa

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
            }


        static void displayOperation()
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


        static void invalidOperation()
            {
                Console.WriteLine("You typed invalid operation, try again: ");
                chooseOperation();
            }
     }
}