using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class TriangleValidator
    {

        #region Private

        private string _commonName;

        #endregion

        public TriangleValidator(string commonName)
        {
            _commonName = commonName;
        }    

        public bool IsTriangle(int firstSide, int secondSide, int thirdSide)
        {
            return ((firstSide + secondSide) < thirdSide)
                    || ((firstSide + thirdSide) < secondSide)
                    || ((secondSide + thirdSide) < firstSide);
        }

        public bool IsRightName(string name)
        {
            return name.Contains(_commonName);
        }
    }
}
