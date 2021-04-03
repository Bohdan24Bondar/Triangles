using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class ValidatorController
    {
        private TriangleValidator _triangleChecker;
        private string _commonName;

        public ValidatorController(string commonName)
        {
            _triangleChecker = new TriangleValidator();
            _commonName = commonName;
        }

        public void StartValidation(string name, params double[] sides)//todo separate into firstSide, second ,third...
        {
            bool isTriangle = _triangleChecker.IsTriangle(sides[0], sides[1], sides[2]);

            if (!isTriangle)
            {
                throw new ArgumentException("Can't build triangle from these sides!\n" +
                        "Summ of two side triangle should be more than third side");
            }

            bool isRightName = _triangleChecker.IsRightName(name, _commonName);

            if (!isRightName)
            {
                throw new ArgumentException($"Name of triangle, should contains {_commonName} in name");
            }
        }
    }
}
