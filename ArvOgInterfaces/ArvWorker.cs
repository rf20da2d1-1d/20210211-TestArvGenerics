using System;

namespace ArvOgInterfaces
{
    public class ArvWorker
    {
        public ArvWorker()
        {
        }

        public void Start()
        {
            //Ifigur c = new Ifigur();
            // kan ikke oprette objekter af Ifigur

            //AbstractFigur c2 = new AbstractFigur("rund");
            // kan ikke oprette objekter af AbstractFigur


            Ifigur c3 = new Cirkel("rund", 4);
            

            Console.WriteLine($"omkreds {c3.GetOmkreds()}  areal {c3.GetAreal()}");

        }
    }
}