using FigureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class Viewer : IViewer
    {
        #region Consts

        public const int DIVIDER = 2;
        public const char SEPARATOR = ',';
        public const char LINES_SEPARATOR = '\n';
        public const int COUNT_OF_SEPARATE = 4;
        public const string FIGURE_START_MESSAGE = "Triangles list:";

        #endregion

        #region Private

        private string _startMessage;

        #endregion

        public Viewer(string startMessage)
        {
            _startMessage = startMessage;
        }

        public string[] InputParameters() 
        {
            bool isRightParameters;
            string parameters = string.Empty;

            do
            {
                PrintMessage(_startMessage);
                parameters = Console.ReadLine();
                isRightParameters = IsRightParameters(parameters);

            } while (!isRightParameters);

            return SepareteParametrs(parameters);
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

        private string[] SepareteParametrs(string parameters)
        {
            string[] triangleArgs = parameters.Split(new char[] { SEPARATOR });

            for (int index = 0; index < triangleArgs.Length; index++)
            {
                triangleArgs[index] = triangleArgs[index].Trim();
            }

            return triangleArgs;
        }

        public string InputAnswer(string message)
        {
            PrintMessage(message);

            return Console.ReadLine();
        }

        public void ShowMessage(string message)
        {
            PrintMessage(message);
            Console.SetCursorPosition(Console.CursorLeft, ++Console.CursorTop);
            Console.Write("Please, press any key");
            Console.ReadKey();
        }

        public void ShowFigures(IEnumerable<IFigure> sortedFigures)
        {
            PrintMessage(FIGURE_START_MESSAGE);

            foreach (var figure in sortedFigures)
            {
                Console.WriteLine();
                Console.WriteLine(figure.ToString());
            }
        }

        private void PrintMessage(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string[] lines = message.Split(new char[] { LINES_SEPARATOR });
            int middleHeight = (Console.WindowHeight - lines.Length) / DIVIDER;
            int middleWidth = (Console.WindowWidth - lines[0].Length) / DIVIDER;
            
            for (int i = 0; i < lines.Length; i++)
            {
                Console.SetCursorPosition(middleWidth, middleHeight++);
                Console.Write(lines[i]);
            }

            Console.SetCursorPosition(middleWidth, middleHeight++);
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
