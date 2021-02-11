using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class GeneralRegister<T>   // generisk klasse T er generel og bestemmes når der oprettes et objekt
    {
        private List<T> elementer = new List<T>();

        public GeneralRegister()
        {
        }

        public void Add(T element)
        {
            elementer.Add(element);
        }

        public void Delete(T element)
        {
            elementer.Remove(element);
        }

        public void PrintAllElementer()
        {
            Console.WriteLine("Alle Elementer");
            foreach (T t in elementer)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("=========================");
        }

        //public T GetById(int id)
        //{
        //    foreach (T t in elementer)
        //    {
        //        if (t.Id == id)
        //        {
        //            return t;
        //        }
        //    }

        //    throw new KeyNotFoundException("No elements with id=" + id);
        //}


    }
}
