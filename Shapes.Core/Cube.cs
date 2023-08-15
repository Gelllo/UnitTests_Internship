using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Core
{
    public record Cube : IShape
    {
        public double Side { get; set; }

        public string Unit { get; set; }

        public Cube(double side, string unit)
        {
            if (side <= 0) throw new ArgumentOutOfRangeException();

            Side = side;
            Unit = unit;
        }

        public override string ToString() => $"Cube - Side:{Side} {Unit}";

        public double GetArea() => 6 * Math.Pow(Side, 2);

        public double GetVolume() => Math.Pow(Side, 3);

    }
}
