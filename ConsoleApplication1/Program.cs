using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static Models.StudentContainer studentContainer = new Models.StudentContainer();

        static void Main(string[] args)
        {
            string userWish;
            do
            {
                Console.WriteLine("Please ENLIST or DISPLAY: ");
                userWish = Console.ReadLine();

                if (Models.Validation.operationValidation(userWish))
                {
                    if (userWish.ToLower() == Models.Operations.displayOperation)
                        displayOperation();
                    else if (userWish.ToLower() != Models.Operations.enlistOperation)
                        enlistOperation();
                }
            } while (userWish.ToLower() != Models.Operations.displayOperation);
        }

        public static void displayOperation()
        {
            int x = 0;
            List<Student> students = Models.StudentContainer.Fetch();

            if (!students.Any())
            {
                Console.WriteLine("No students in the list.");
            }
            else
            {
                foreach (Student s in students)
                {
                    x++;
                    Console.WriteLine("{0}. {1}, {2}, {3}", x, s.first_name, s.last_name, s.GPA);
                }

            }
        }

        public static void enlistOperation()
        {
            string firstName, lastName, stringGpa;
            float Gpa;
            bool state = true;

            do
            {
                Console.WriteLine("First name: ");
                firstName = Console.ReadLine();
                state = Models.Validation.firstNameValidation(firstName);
            } while (!state);

            do
            {
                Console.WriteLine("\nLast name: ");
                lastName = Console.ReadLine();
                state = Models.Validation.lastNameValidation(lastName);
            } while (!state);

            do
            {
                Console.Write("\nGPA: ");
                stringGpa = Console.ReadLine(); //string jer unosis brojeve i znakove tj. tocku (4.6) i onda
                state = Models.Validation.gpaValidation(stringGpa);//on to parsa u jedan format i brojeve i tocku
            } while (!state);

            float.TryParse(stringGpa, out Gpa);
            Student student = new Student(Models.StudentIdGenerator.getInstance().generateID(), firstName, lastName, Gpa);
            studentContainer.Add(student);
        }
    }
}