using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public interface IFigureValidator
    {
        bool HasRightSides(params double[] sides);

        bool IsRightName(string name, string commonName);
    }
}
