using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Core
{
    public record Sphere : IShape
    {
        public double Radius { get; set; }

        public string Unit { get; set; }

        public Sphere(double radius, string unit)
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException();

            Radius = radius;
            Unit = unit;
        }

        public override string ToString() => $"Sphere - Radius:{Radius} {Unit}";

        public double GetArea() => 4 * Math.PI * Math.Pow(Radius, 2);

        public double GetVolume() => 4.0 * Math.Pow(Radius, 3) / 3.0;
    }
}
