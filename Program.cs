using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using FigureLibrary;

namespace TriangleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

                IViewer figuresViwer = new Viewer(DefaultSettings.START_MESSAGE);
                TriangleValidatorFactory validatorCreator = new TriangleValidatorFactory();
                IFigureValidator triangleChecker = validatorCreator.Create();
                TriangleFactory triangleBuilder = new TriangleFactory();
                FigureComparerBySquareFactory creator = new FigureComparerBySquareFactory();
                IComparer<IFigure> triangleComparer = creator.Create();
                IContinueChecker continueChecker = new ContinueChecker(new string[] 
                { 
                    DefaultSettings.FIRST_ANSWER, DefaultSettings.SECOND_ANSWER 
                });
                INumbericsValidator numbersChecker = new NumbericsValidator();
                FiguresSorterByDescendingFactory sorterFactory = new FiguresSorterByDescendingFactory();
                ConsoleController application = new ConsoleController(DefaultSettings.INSTRUCTION,
                        continueChecker, numbersChecker, triangleChecker,
                        triangleBuilder, triangleComparer, sorterFactory,
                        figuresViwer);

                application.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(DefaultSettings.INSTRUCTION);
            }

            Console.ReadKey();
        }
    }
}
