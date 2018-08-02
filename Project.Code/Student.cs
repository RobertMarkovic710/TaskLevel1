using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Code
{
    public class Student : Person
    {
        public float GPA { get; set; }
        public Student(int id, string firstName, string lastName, float gpa)
        {
            this.ID = id;
            this.first_name = firstName;
            this.last_name = lastName;
            this.GPA = gpa;
        }
    }
}
