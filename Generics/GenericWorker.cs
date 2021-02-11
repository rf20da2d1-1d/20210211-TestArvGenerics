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

            GeneralRegister<Person> personer = new GeneralRegister<Person>();
            personer.Add(new Person(1, "peter"));
            personer.Add(new Person(2, "charlotte"));
            personer.Add(new Person(3, "jakob"));

            personer.PrintAllElementer();


            GeneralRegister<string> tekst = new GeneralRegister<string>();
            tekst.Add("Hej");
            tekst.Add("med");
            tekst.Add("dig");

            tekst.PrintAllElementer();
        }
    }
}