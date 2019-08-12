using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApplication
{
    public class Student : AbstractPerson
    {
        public int StudentNumber { get; private set; }

        public Student(string firstName, string lastName, int studentNumber) : 
            base(firstName, lastName)
        {
            StudentNumber = studentNumber;
        }
    }
}
