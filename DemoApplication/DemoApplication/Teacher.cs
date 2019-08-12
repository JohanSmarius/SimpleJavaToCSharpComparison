using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApplication
{
    public class Teacher : AbstractPerson
    {
        public string TeacherCode { get; private set; }

        public Teacher(string firstName, string lastName, string teacherCode) : 
            base(firstName, lastName)
        {
            TeacherCode = teacherCode;
        }
    }
}
