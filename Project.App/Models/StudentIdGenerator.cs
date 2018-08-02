using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Models
{
    public class StudentIdGenerator
    {
        private static StudentIdGenerator newInstance;
        private int mIdCounter;

        protected StudentIdGenerator()
        {
            this.mIdCounter = 0;
        }
        public static StudentIdGenerator getInstance()
        {
            if (newInstance == null)
            {
                newInstance = new StudentIdGenerator();
            }
            return newInstance;
        }
        public int generateID()
        {
            return this.mIdCounter++;
        }
    }
}
