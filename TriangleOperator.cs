using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class TriangleOperator
    {
        private List<ITriangle> _plentyTriangles;

        public TriangleOperator()
        {
            _plentyTriangles = new List<ITriangle>();
        }

        public IEnumerable<ITriangle> SortTriagleByDissending()
        {
            var sortedTriangles = _plentyTriangles
                    .OrderByDescending(t => t.Square);

            foreach (var t in sortedTriangles)
            {
                yield return t.Clone();
            }
        }

        public void AddTriangle(ITriangle triangle)
        {
            if (triangle == null)
            {
                throw new ArgumentNullException($"Argument {triangle} is null");
            }

            _plentyTriangles.Add(triangle);
        }

    }
}
