using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Factory.Exercises.PersonFactory
{
    public class PersonFactory
    {
        private int personCount;

        public PersonFactory()
        {
            personCount = 0;
        }

        public Person CreatePerson(string name)
        {
            return new Person() { Id = personCount++, Name = name };
        }
    }
}
