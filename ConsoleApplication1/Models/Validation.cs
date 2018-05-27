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
        const string invalidNameFormat = "wrongFirstNameTyped";
        const string invalidLastNameFormat = "wrongLastNameTyped";
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
                case "wrongFirstNameTyped":
                    Console.WriteLine("You typed invalid first name format.");
                    break;
                case "wrongLastNameTyped":
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

        public static bool operationValidation(string userWish)
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

        public static bool firstNameValidation(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                showMessage(noKeywordsTyped);
                return false;
            }
            else if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                showMessage(invalidNameFormat);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool lastNameValidation(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                showMessage(noKeywordsTyped);
                return false;
            }
            else if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                showMessage(invalidLastNameFormat);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool gpaValidation (string value)
        {
            float gpa;
            if (string.IsNullOrEmpty(value))
            {
                showMessage(noKeywordsTyped);
                return false;
            }
            else if (!float.TryParse(value, out gpa))
            {
                showMessage(invalidGpaFormat);
                return false;
            }
            else if (gpa < 1 || gpa > 5)
            {
                showMessage(invalidGpaValue);
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}