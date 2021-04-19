using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class FigureComparerBySquareFactory 
    {
        public IComparer<IFigure> Create()
        {
            return new FigureComparerBySquare();
        }
    }
}
