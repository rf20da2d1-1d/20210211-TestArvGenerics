using System;

namespace Generics
{
    public class GenericWorker
    {
        public GenericWorker()
        {
        }

        public void Start()
        {
            PersonRegister pregister = new PersonRegister();
            pregister.Add(new Person(1, "peter"));
            pregister.Add(new Person(2, "charlotte"));
            pregister.Add(new Person(3, "jakob"));

            pregister.PrintAllPersons();

            Console.WriteLine($"Person med id=3 er: " + pregister.GetById(3));

        }
    }
}