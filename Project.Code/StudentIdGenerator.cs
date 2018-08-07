using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Code
{
    public class StudentIdGenerator
    {
        private static StudentIdGenerator newInstance;
        private int myIdCounter;

        protected StudentIdGenerator()
        {
            this.myIdCounter = 0;
        }

        public static StudentIdGenerator GetInstance()
        {
            if (newInstance == null)
            {
                newInstance = new StudentIdGenerator();
            }
            return newInstance;
        }

        public int GenerateId()
        {
            return this.myIdCounter++;
        }
    }
}
