using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Core
{
    public class ShapeList
    {
        private ICollection<IShape> ShapesList { get; set; }
        public ShapeList()
        {
            ShapesList = new List<IShape>();
        }

        public void AddShape(IShape shape)
        {
            ShapesList = ShapesList.Append(shape).ToList();
        }

        public void RemoveShape(IShape shape)
         {
            if (ShapesList.Any(x => x == shape))
            {
                ShapesList.Remove(shape);
            }
        }

        public List<IShape> GetShapeList() =>   ShapesList.ToList();

        public int GetNumberOfShapes() => ShapesList.Count();

        public IShape GetShapeWithMaxArea() => ShapesList.OrderByDescending(x => x.GetArea()).First();

        public IShape GetShapeWithMaxVolume() => ShapesList.OrderByDescending(x => x.GetVolume()).First();

        public double GetTotalArea() => ShapesList.Aggregate(0.0, (agg, shape) => agg + shape.GetArea());

        public double GetTotalVolume() => ShapesList.Aggregate(0.0, (agg, shape) => agg + shape.GetVolume());

    }
}
