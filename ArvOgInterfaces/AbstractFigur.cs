using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOgInterfaces
{
    public abstract class AbstractFigur : Ifigur
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        protected AbstractFigur(string name)
        {
            _name = name;
        }

        public abstract double GetOmkreds(); // ingen kode eller krop

        public virtual double GetAreal()
        {
            return 0;
        }
    }
}
