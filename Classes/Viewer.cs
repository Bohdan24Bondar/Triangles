using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class Viewer
    {
        #region Consts

        public const int DIVIDER = 2;

        #endregion

        #region Private

        private string _startMessage;

        #endregion

        public Viewer(string startMessage)
        {
            _startMessage = startMessage;
        }

        public void InputParametrs() //TODO
        {
            
        }

        public void ShowFigures(IEnumerable<IFigure> sortedFigures)
        {
            int middleHeight = Console.WindowHeight / DIVIDER;
            int middleWidth = (Console.WindowWidth + _startMessage.Length) / DIVIDER;

            Console.Clear();
            Console.SetCursorPosition(middleWidth, middleHeight);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_startMessage);
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var figure in sortedFigures)
            {
                figure.ToString();
            }
        }
    }
}
