using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
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
