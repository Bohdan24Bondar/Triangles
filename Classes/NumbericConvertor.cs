using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class NumbericConvertor
    {
        #region Private

        private string[] _numbers;

        #endregion

        public NumbericConvertor(params string[] numbers)
        {
            _numbers = (string[])numbers.Clone();
        }

        public void GetNumbers(out double[] numbers)
        {
            double currentNumber;
            bool areNumberics;
            numbers = new double[_numbers.Length];

            for (int index = 0; index < _numbers.Length; index++)
            {
                areNumberics = double.TryParse(_numbers[index], out currentNumber);

                if (!areNumberics)
                {
                    throw new FormatException($"Args number {index} are not numberic");// todo
                }

                numbers[index] = currentNumber;
            }
        }
    }
}
