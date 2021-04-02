using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class TriangleOperator
    {
        private List<IFigure> _plentyTriangles;

        public TriangleOperator()
        {
            _plentyTriangles = new List<IFigure>();
        }

        public IEnumerable<IFigure> SortTriagleByDissending()
        {
            return _plentyTriangles
                    .OrderByDescending(t => t.Square);
        }

        public void AddTriangle(IFigure triangle)
        {
            if (triangle == null)
            {
                throw new ArgumentNullException($"Argument {triangle} is null");
            }

            _plentyTriangles.Add(triangle);
        }

    }
}
