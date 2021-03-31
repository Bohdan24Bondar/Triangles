using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    interface ITriangle : ICloneable
    {
        string Name { get; }

        double Square { get; }
    }
}
