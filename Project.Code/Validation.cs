using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Project.Code
{
    public static class Validation
    {
        const string operationName = "validOperationName";
        const string noKeywordsTyped = "noInputData";
        const string invalidNameFormat = "wrongFirstNameTyped";
        const string invalidLastNameFormat = "wrongLastNameTyped";
        const string invalidGpaFormat = "wrongFormat";
        const string invalidGpaValue = "wrongValue";
        
        public static void ShowMessage(string value)
        {
            switch (value)
            {
                case operationName:
                    Console.WriteLine("Operation non-existing, please use appropriate operation.");
                    break;
                case noKeywordsTyped:
                        Console.WriteLine("You need to insert value.");
                        break;
                case invalidNameFormat:
                    Console.WriteLine("You typed invalid first name format.");
                    break;
                case invalidLastNameFormat:
                    Console.WriteLine("You typed invalid last name format.");
                    break;
                case invalidGpaFormat:
                    Console.WriteLine("You need to insert numerical value.");
                    break;
                case invalidGpaValue:
                    Console.WriteLine("Your GPA should be 1.0 - 5.0 number.");
                    break;
            }
        }

        public static bool OperationValidation(string userWish)
        {
            if (string.IsNullOrEmpty(userWish))
            {
                ShowMessage(noKeywordsTyped);
                return false;
            }
            else if (userWish.ToLower() != Operations.DisplayOperation && userWish.ToLower() != Operations.EnlistOperation)
            {
                ShowMessage(operationName);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool FirstNameValidation(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                ShowMessage(noKeywordsTyped);
                return false;
            }
            else if (!Regex.IsMatch(value, @"^[-a-zA-Z\s]+$")) //allows letters a-z, spaces and dashes
            {
                ShowMessage(invalidNameFormat);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool LastNameValidation(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                ShowMessage(noKeywordsTyped);
                return false;
            }
            else if (!Regex.IsMatch(value, @"^[-a-zA-Z\s]+$"))
            {
                ShowMessage(invalidLastNameFormat);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool GpaValidation (string value)
        {
            float gpa;
            if (string.IsNullOrEmpty(value))
            {
                ShowMessage(noKeywordsTyped);
                return false;
            }
            else if (!float.TryParse(value, out gpa))
            {
                ShowMessage(invalidGpaFormat);
                return false;
            }
            else if (gpa < 1 || gpa > 5)
            {
                ShowMessage(invalidGpaValue);
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}