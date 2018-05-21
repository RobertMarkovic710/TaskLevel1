using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ConsoleApplication1.Models
{
    public static class Validation
    {
        const string validOperationName = "operationName";
        const string noKeywordsTyped = "noInputData";
        const string invalidNameFormat = "wrongNameTyped"; //ime i prezime ima zajednicki
        const string invalidLastNameFormat = "wrongLastName";
        const string invalidGpaFormat = "wrongFormat";
        const string invalidGpaValue = "wrongValue";

        public static void showMessage(string value)
        {
            switch (value)
            {
                case "operationName":
                    Console.WriteLine("You typed invalid operation name.");
                    break;
                case "noInputData":
                        Console.WriteLine("You need to insert something.");
                        break;
                case "wrongNameTyped":
                    Console.WriteLine("You typed invalid name format.");
                    break;
                case "wrongLastName":
                    Console.WriteLine("You typed invalid last name format.");
                    break;
                case "wrongFormat":
                    Console.WriteLine("You need to insert number for GPA.");
                    break;
                case "wrongValue":
                    Console.WriteLine("Your GPA should be 1.0 - 5.0 number.");
                    break;
            }
        }

        public static bool operationNameValidation(string userWish)
        {
            if (string.IsNullOrEmpty(userWish))
            {
                showMessage(validOperationName);
                return false;
            }
            else if (userWish.ToLower() != Operations.displayOperation && userWish.ToLower() != Operations.enlistOperation)
            {
                showMessage(validOperationName);
                return false;
            }
            else
            {
                return true;
            }
        }

        //public static bool 

    }
}