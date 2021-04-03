using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class TriangleValidator
    {  
        public bool IsTriangle(double firstSide, double secondSide, double thirdSide)
        {
            return ((firstSide + secondSide) > thirdSide)
                    && ((firstSide + thirdSide) > secondSide)
                    && ((secondSide + thirdSide) > firstSide);
        }

        public bool IsRightName(string name, string commonName)
        {
            return name.Contains(commonName);
        }
    }
}
