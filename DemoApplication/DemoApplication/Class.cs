using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.XPath;

namespace DemoApplication
{
    public class Class
    {
        public string Title { get; private set; }
        public Teacher Teacher { get; private set; }

        private List<Student> _students = new List<Student>();

        public Class(string title, Teacher teacher)
        {
            Title = title;
            Teacher = teacher;
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public IEnumerable<IPerson> GetAllPersons()
        {
            var result = new List<IPerson>();

            _students.ForEach(student => result.Add(student));

            result.Add(Teacher);

            return result;
        }
    }
}
