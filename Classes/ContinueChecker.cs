using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class ContinueChecker
    {
        #region Private

        private string[] _anwersOptions;

        #endregion

        public ContinueChecker(string[] anwersOptions)
        {
            _anwersOptions = (string[])anwersOptions.Clone();
        }

        public bool CanContinue(string userAnswer)
        {
            bool canContinue = false;

            string answer = userAnswer.ToLower();

            for (int index = 0; index < _anwersOptions.Length; index++)
            {

                if (_anwersOptions[index] == answer)
                {
                    canContinue = true;
                    break;
                }
            }

            return canContinue;
        }
    }
}
