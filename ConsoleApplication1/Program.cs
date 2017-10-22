using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections; //potrebno za new arraylist

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            chooseOperation();
        }

        static void chooseOperation()
        {
            Console.WriteLine("Please ENLIST or DISPLAY: ");
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

    public static List<object> studentInfoList = new List<object>();
        static void enlistOperation()
        {
            Student person = new Student();

            Console.Write("Your name: ");
            person.studentFirstName = Console.ReadLine(); //Console.Write("Your name is {0} {1}", person.studentFirstName, person.studentLastName);
            studentInfoList.Add(person.studentFirstName);

            Console.Write("Your last name: ");
            person.studentLastName = Console.ReadLine();
            studentInfoList.Add(person.studentLastName);

            Console.Write("Your GPA: ");
            person.studentGpa = Console.ReadLine(); //to.parse staviti jer ako se unese bilo koji znak osim broja apk se srusi, provjeriti tipove podataka
                int number;
                Int32.TryParse(person.studentGpa, out number);
            studentInfoList.Add(person.studentGpa);

            chooseOperation();
        }


        static void displayOperation()
        {
            foreach (object info in studentInfoList)
            {
                Console.WriteLine(info);
            }
            chooseOperation();
        }


        static void invalidOperation()
        {
            Console.WriteLine("You typed invalid operation, try again: ");
            chooseOperation();
        }
    }
}