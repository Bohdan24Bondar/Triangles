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
        private ParametersValidator _parametersChecker;
        private string _figureName;
        private int _countOfSide;

        public ValidatorController(TriangleValidator triangleChecker, 
                ParametersValidator parametersChecker, string triangleName,
                int countOfSide)
        {
            _triangleChecker = triangleChecker;
            _parametersChecker = parametersChecker;
            _figureName = triangleName;
            _countOfSide = countOfSide;
        }

        public void StartValidation()
        {
            int[] sides = new int[_countOfSide];

            if (_triangleChecker.IsRightName(_figureName))
            {
                throw new ArgumentException($"Wrong triangle name!" +
                    $"\n Has to contain {_figureName}");  //TODO Exeption
            }

            if (!_triangleChecker.IsTriangle(sides[0], sides[1], sides[2]))
            {
                throw new ArgumentException("Figure is not treiangle"); //TODO Exeption
            }

        }
    }
}
