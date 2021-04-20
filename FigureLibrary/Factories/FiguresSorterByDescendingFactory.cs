using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class FiguresSorterByDescendingFactory 
    {
        public IFiguresSorter Create(IEnumerable<IFigure> plentyFigures,
                IComparer<IFigure> figuresComparer)
        {
            return new FiguresSorterByDescending(plentyFigures, figuresComparer);
        }
    }
}
