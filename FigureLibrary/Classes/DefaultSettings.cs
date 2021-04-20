using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class DefaultSettings
    {
        public const string ANSWER_MESSAGE = "Input answer<y> or <yes> if you want to continue:";
        public const string START_MESSAGE = "Please input parameters of triangle" +
                   " as said in the instruction:";
        public const string INSTRUCTION = "Please, input name of triagle with " +
                "common name <Triangle>\nthen add three sides of triangle where" +
                " separetor will be coma <,>\nalso sum of size of two sides must be more " +
                "than size of third side \nFor example:Trianle12, 44.6, 22.7, 33.03";
        public const string FIRST_ANSWER = "y";
        public const string SECOND_ANSWER = "yes";
        public const double DEVIDER = 2.0;
        public const string COMMON_NAME = "Triangle";
        public const string WRONG_FIGURES_ARGS = "Introduced parameters of figure are not correct!";
        public const string WRONG_FORMAT_ARGS = "Introduced parameters are not numbers";
    }
}
