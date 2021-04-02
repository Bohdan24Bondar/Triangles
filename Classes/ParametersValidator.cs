using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class ParametersValidator
    {
        #region Private

        private string[] _sides;

        #endregion

        public ParametersValidator(params string[] sides)
        {
            _sides = (string[])sides.Clone();
        }

        public void GetSides(out int[] lengthOfSides)
        {
            int currentSide;
            lengthOfSides = new int[_sides.Length];
            bool areNumberics;

            for (int index = 0; index < _sides.Length; index++)
            {
                areNumberics = int.TryParse(_sides[index], out currentSide);

                if (!areNumberics)
                {
                    throw new ArgumentException($"Side number {index} is not numberic"); //TODO Exeption
                }

                if (currentSide < 0)
                {
                    throw new ArgumentException($"Side number {index} less than 0"); //TODO Exeption
                }

                lengthOfSides[index] = currentSide;
            }
        }
    }
}
