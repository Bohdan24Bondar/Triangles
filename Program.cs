using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TriangleTask
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle("t1", 13, 44, 23);
            Triangle t2 = new Triangle("t2", 12, 3, 8);
            Triangle t3 = new Triangle("t3", 166, 36, 8);

            double n = t1.Square;

            TriangleOperator op = new TriangleOperator();

            op.AddTriangle(t1);
            op.AddTriangle(t2);
            op.AddTriangle(t3);

            var result = op.SortTriagleByDissending();

            foreach (var t in result)
            {
                Console.WriteLine(t.ToString());
            }

            Console.ReadKey();
        }
    }
}
