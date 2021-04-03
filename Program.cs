using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            try
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                ConsoleController application = new ConsoleController(INSTRUCTION);
                application.Run();
            }
            catch (Exception)
            {
                Console.WriteLine(INSTRUCTION);
            }

            Console.ReadKey();
        }
    }
}
