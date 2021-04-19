using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    class FiguresSorterByDescending : IFiguresSorter
    {
        private readonly IEnumerable<IFigure> _plentyFigures;
        private IComparer<IFigure> _figuresComparer;

        public FiguresSorterByDescending(IEnumerable<IFigure> plentyFigures, IComparer<IFigure> figuresComparer)
        {
            _plentyFigures = plentyFigures;
            _figuresComparer = figuresComparer;
        }

        public IEnumerable<IFigure> SortFigures()
        {
            if (_plentyFigures == null)
            {
                throw new ArgumentNullException("There are no one triangles!");
            }

            return _plentyFigures.OrderByDescending(t => t, _figuresComparer); 
        }
    }
}
