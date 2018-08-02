using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project.App
{
    class Program
    {
        static StudentContainer studentContainer = new StudentContainer();
        
        static void Main(string[] args)
        {
            string userWish;
            do
            {
                Console.WriteLine("Please ENLIST or DISPLAY: ");
                userWish = Console.ReadLine();
                
                if (Validation.OperationValidation(userWish))
                {

                    if (userWish.Equals(Models.Operations.DisplayOperation, StringComparison.InvariantCultureIgnoreCase))
                        DisplayOperation(); 

                    else if (userWish.Equals(Models.Operations.EnlistOperation, StringComparison.InvariantCultureIgnoreCase))
                        EnlistOperation();

                }
            } while (!userWish.Equals(Models.Operations.DisplayOperation, StringComparison.InvariantCultureIgnoreCase));
        }

        public static void DisplayOperation()
        {
            int counter = 0;
            List<Student> students = studentContainer.Fetch();

            if (!students.Any())
            {
                Console.WriteLine("No students in the list.");
            }
            else
            {
                foreach (Student s in students)
                {
                    counter++;
                    Console.WriteLine("\nStudents in system: ");
                    Console.WriteLine("{0}. {1}, {2} - {3}", counter, s.first_name, s.last_name, s.GPA);
                }

            }
        }

        public static void EnlistOperation()
        {
            string firstName, lastName, stringGpa;
            float gpa;
            bool state = true;

            do
            {
                Console.WriteLine("First name: ");
                firstName = Console.ReadLine();
                state = Models.Validation.FirstNameValidation(firstName);
            } while (!state);

            do
            {
                Console.WriteLine("Last name: ");
                lastName = Console.ReadLine();
                state = Models.Validation.LastNameValidation(lastName);
            } while (!state);

            do
            {
                Console.Write("GPA: ");
                stringGpa = Console.ReadLine();
                state = Models.Validation.GpaValidation(stringGpa);
            } while (!state);

            float.TryParse(stringGpa, out gpa);
            Student student = new Student(Models.StudentIdGenerator.getInstance().generateID(), firstName, lastName, gpa);
            studentContainer.Add(student);
        }
    }
}