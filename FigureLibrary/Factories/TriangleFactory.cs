using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class TriangleFactory : FigureFactory
    {
        public override IFigure Create(string name, params double[] sides)
        {
            return new Triangle(name, sides[0], sides[1], sides[2]);
        }

    }
}
