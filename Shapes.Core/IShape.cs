using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Core
{
    public interface IShape
    {
        public double GetArea();

        public double GetVolume();
    }
}
