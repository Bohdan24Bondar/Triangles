using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    class TriangleValidator : IFigureValidator
    {
        public bool HasRightSides(params double[] sides)
        {
            return ((sides[0] + sides[1]) > sides[2])
                    && ((sides[0] + sides[2]) > sides[1])
                    && ((sides[1] + sides[2]) > sides[0]);
        }

        public bool IsRightName(string name, string commonName)
        {
            return name.Contains(commonName);
        }
    }
}
