using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class FiguresSorterByDescendingFactory 
    {
        #region Private

        private readonly IEnumerable<IFigure> _plentyFigures;
        private IComparer<IFigure> _figuresComparer;

        #endregion

        public FiguresSorterByDescendingFactory(IEnumerable<IFigure> plentyFigures,
                IComparer<IFigure> figuresComparer)
        {
            _plentyFigures = plentyFigures;
            _figuresComparer = figuresComparer;
        }

        public IFiguresSorter Create()
        {
            return new FiguresSorterByDescending(_plentyFigures, _figuresComparer);
        }
    }
}
