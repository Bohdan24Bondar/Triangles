using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public interface IFigureContainer
    {
        void AddFigure(IFigure figure);

        IEnumerable<IFigure> GetFigures();
    }
}
