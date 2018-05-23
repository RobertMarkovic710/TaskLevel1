using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    //enlistOperation();
                }
            } while (userWish.ToLower() != Models.Operations.displayOperation);
        }

        public static void displayOperation()
        {
            List<Student> someStudent = Models.StudentContainer.Fetch();
        }
    }
}