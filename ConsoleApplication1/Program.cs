using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            chooseOperation();
        }


        public static void chooseOperation()
        {
            string userWish;
            do {
                Console.WriteLine("Please ENLIST or DISPLAY: ");
                userWish = Console.ReadLine();

                if (Models.Validation.operationNameValidation(userWish))
                {
                    if (userWish.ToLower() == Models.Operations.displayOperation) ;
                    //displayOperacija();
                    else if (userWish.ToLower() != Models.Operations.enlistOperation) ;
                    enlistOperation();
                }
            } while (userWish.ToLower() != Models.Operations.displayOperation);
        }

        public static List<object> studentInfoList = new List<object>();

        public static void enlistOperation()
        {
            Student person = new Student();

            Console.Write("Your name: ");
            person.studentFirstName = Console.ReadLine(); //Console.Write("Your name is {0} {1}", person.studentFirstName, person.studentLastName);
            studentInfoList.Add(person.studentFirstName);

            Console.Write("Your last name: ");
            person.studentLastName = Console.ReadLine();
            studentInfoList.Add(person.studentLastName);

            Console.Write("Your GPA: ");
            person.studentGpa = Console.ReadLine();
            int number;
            Int32.TryParse(person.studentGpa, out number);
            studentInfoList.Add(person.studentGpa);

            chooseOperation();
        }
    }
}