using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    class FiguresContainer : IFigureContainer
    {
        #region Private

        private Queue<IFigure> _plentyFigures;

        #endregion

        public FiguresContainer()
        {
            _plentyFigures = new Queue<IFigure>();
        }

        public void AddFigure(IFigure figure)
        {
            if (figure == null)
            {
                throw new ArgumentNullException($"Argument {figure} is null");
            }

            _plentyFigures.Enqueue(figure);
        }

        public IEnumerable<IFigure> GetFigures()
        {
            if (_plentyFigures.Count == 0)
            {
                throw new ArgumentException("There are not any figures");
            }

            return _plentyFigures;
        }
    }
}
