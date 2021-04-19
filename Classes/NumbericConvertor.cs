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
            _numbers = numbers;
        }

        public void GetNumbers(out double[] numbers)
        {
            numbers = new double[_numbers.Length];

            for (int index = 0; index < _numbers.Length; index++)
            {
                numbers[index] = double.Parse(_numbers[index]);
            }
        }
    }
}
