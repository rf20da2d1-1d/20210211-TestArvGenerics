using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOgInterfaces
{
    public class Cirkel:AbstractFigur
    {
        private double _radius;
        public Cirkel(string name, double radius) : base(name)
        {
            _radius = radius;
        }

        public override double GetOmkreds()
        {
            return 2 * Math.PI * _radius;
        }

        public override double GetAreal()
        {
            return Math.PI*_radius*_radius;
        }
    }
}
