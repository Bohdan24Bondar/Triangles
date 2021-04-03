using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class Viewer
    {
        #region Consts

        public const int DIVIDER = 2;
        public char SEPARATOR = ',';
        public int COUNT_OF_SEPARATE = 4;

        #endregion

        #region Private

        private string _startMessage;

        #endregion

        public Viewer(string startMessage)
        {
            _startMessage = startMessage;
        }

        public string[] InputParameters() //TODO
        {
            bool isRightParameters;
            string parameters = string.Empty;
            do
            {
                SetCursorPosition(_startMessage);
                parameters = Console.ReadLine();
                isRightParameters = IsRightParameters(parameters);

            } while (!isRightParameters);

            return parameters.Split(new char[] { SEPARATOR });
        }

        private bool IsRightParameters(string parameters)
        {
            string[] triangleArgs = parameters.Split(new char[] {SEPARATOR});

            if (triangleArgs.Length != COUNT_OF_SEPARATE)
            {
                return false;
            }

            return true;
        }

        public string InputAnswer(string message)//todo out
        {
            SetCursorPosition(message);

            return Console.ReadLine();
        }

        public void ShowMessage(string message)
        {
            SetCursorPosition(message);
        }

        public void ShowFigures(IEnumerable<IFigure> sortedFigures)
        {
            SetCursorPosition("Triangle list:"); // todo as args string

            foreach (var figure in sortedFigures)
            {
                Console.Write(figure.ToString());
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop++);
            }
        }

        private void SetCursorPosition(string message)
        {
            int middleHeight = (Console.WindowHeight - 1) / DIVIDER;
            int middleWidth = (Console.WindowWidth - message.Length) / DIVIDER;

            Console.Clear();
            Console.SetCursorPosition(middleWidth, middleHeight++);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(message);
            Console.SetCursorPosition(middleWidth, middleHeight);
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
