using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class FigureComparerBySquare : IComparer<IFigure>
    {
        public int Compare(IFigure first, IFigure second)
        {
            int result = 0;

            if (first.Square > second.Square)
            {
                result = 1;
            }

            if (first.Square < second.Square)
            {
                result = -1;
            }

            return result;
        }
    }
}
