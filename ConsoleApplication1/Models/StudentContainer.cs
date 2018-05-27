using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Models
{
    public class StudentContainer
    {
        private List<Student> someStudent; //deklaracija liste koja se sastoji od someStudent članova

       public StudentContainer()
        {
            someStudent = new List<Student>();
        }

        public void Add(Student student)
        {
            someStudent.Add(student);
        }

        public void Remove(Student student)
        {
            for(int y=0; y<someStudent.Count; y++)
            {
                if (student.Equals(someStudent[y]))
                {
                    someStudent.RemoveAt(y);
                    break;
                }
            }
        }

        public void Sort()
        {
            if (someStudent != null)
                someStudent.OrderBy(y => y.last_name);
        }

        public List<Student> Fetch()
        {
            this.Sort();
            return someStudent;
        }
    }
}
