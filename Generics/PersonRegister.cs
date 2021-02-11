using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class PersonRegister
    {
        private List<Person> personer = new List<Person>();

        public PersonRegister()
        {
        }

        public void Add(Person person)
        {
            personer.Add(person);
        }

        public void Delete(Person person)
        {
            personer.Remove(person);
        }

        public void PrintAllPersons()
        {
            Console.WriteLine("Alle Personer");
            foreach (Person p in personer)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("=========================");
        }

        public Person GetById(int id)
        {
            foreach (Person p in personer)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }

            throw new KeyNotFoundException("No persons with id=" + id);
        }

    }
}
