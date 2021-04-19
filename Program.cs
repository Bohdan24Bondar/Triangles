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
        #region Instruction

        public const string INSTRUCTION = "Please, input name of triagle with " +
                "common name <Triangle> than add three sides of triangle where " +
                "separetor will be coma <,> also sum of size two sides must be more" +
                "than size of third side \nFor example:\n Trianle 2, 44.6, 22.7, 33.03";

        #endregion

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            FiguresContainerFactory containerCreator = new FiguresContainerFactory();
            IFigureContainer trianglesContainer = containerCreator.Create();

            TriangleValidatorFactory validatorCreator = new TriangleValidatorFactory();
            IFigureValidator triangleChecker =  validatorCreator.Create();


            TriangleFactory triangleBuilder = new TriangleFactory();
            
            FigureComparerBySquareFactory creator = new FigureComparerBySquareFactory();
            IComparer<IFigure> triangleComparer = creator.Create();

            IContinueChecker continueChecker = new ContinueChecker(new string[] { "y", "yes" });

            INumbericsValidator numbersChecker = new NumbericsValidator();


            ConsoleController application = new ConsoleController(INSTRUCTION, continueChecker, 
                    numbersChecker, trianglesContainer, triangleChecker, triangleBuilder, triangleComparer);//todo consts
            application.Run();

            Console.ReadKey();
        }
    }
}
