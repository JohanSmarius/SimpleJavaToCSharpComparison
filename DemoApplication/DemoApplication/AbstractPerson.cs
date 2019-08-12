using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApplication
{
    public abstract class AbstractPerson : IPerson
    {
        protected AbstractPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
