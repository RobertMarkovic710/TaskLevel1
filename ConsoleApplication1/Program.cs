using System;
using System.Collections.Generic;
using System.Linq;         //int only numbers, string can do booth
using System.Text;

namespace ConsoleApplication1
{
    class Program         //ctrl + F5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please ENLIST or DISPLAY: ");
            String ChooseOperation = (Console.ReadLine());

            if (ChooseOperation == "enlist" )
            {
                Console.WriteLine("Please write your first name: ");
                String StudentFirstName = Console.ReadLine();

                Console.WriteLine("Please write your last name: ");
                String StudentLastName = Console.ReadLine();

                Console.WriteLine("Please write your GPA: ");
                String StudentGPA = Console.ReadLine();
            }
            else if (ChooseOperation == "display")
            {
 
            }
        }
    }
}
