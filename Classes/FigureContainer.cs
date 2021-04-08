using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class FigureContainer
    {
        private Queue<IFigure> _plentyTriangles;

        public FigureContainer()
        {
            _plentyTriangles = new Queue<IFigure>();
        }

        public IEnumerable<IFigure> SortTriagleByDissending()
        {
            if (_plentyTriangles == null)
            {
                throw new ArgumentNullException("There are no one triangles!");
            }

            return _plentyTriangles
                    .OrderByDescending(t => t.Square);
        }

        public void AddTriangle(IFigure triangle)
        {
            if (triangle == null)
            {
                throw new ArgumentNullException($"Argument {triangle} is null");
            }

            _plentyTriangles.Enqueue(triangle);
        }
    }
}
