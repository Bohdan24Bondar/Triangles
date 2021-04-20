using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FigureLibrary;

namespace TriangleTask
{
    public interface IViewer
    {
        string[] InputParameters();

        string InputAnswer(string message);

        void ShowFigures(IEnumerable<IFigure> sortedFigures);

        void ShowMessage(string message);
    }
}
