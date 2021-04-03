using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class ConsoleController
    {

        #region Consts

        public const string COMMON_NAME = "Triangle";

        #endregion

        #region Private

        private NumbericConvertor _sidesConvertor;
        private TrianglesOperator _trianglesSorter;
        private ValidatorController _parametersValidator;
        private Viewer _trianglesViwer;
        private ContinueChecker _currentCondition;
        private string _insrtuction;

        #endregion

        public ConsoleController(string instruction)
        {
            _trianglesViwer = new Viewer("Please input parameters of triangle" +
                   " as said in the instruction:"); //todo instruction 
            _trianglesSorter = new TrianglesOperator();
            _parametersValidator = new ValidatorController(COMMON_NAME);
            _currentCondition = new ContinueChecker(new string[] { "y", "yes" });//todo consts
            _insrtuction = instruction;
        }

        public void Run()
        {
            bool isNeedRepeat = false;

            do
            {
                try
                {
                    bool canContinue = true;
                    string[] arguments;

                    do
                    {
                        arguments = _trianglesViwer.InputParameters();
                        _sidesConvertor = new NumbericConvertor(arguments[1], 
                                arguments[2], arguments[3]);
                        double[] sides;
                        _sidesConvertor.GetNumbers(out sides);
                        _parametersValidator.StartValidation(arguments[0], sides);
                        _trianglesSorter.AddTriangle(new Triangle(arguments[0], 
                                sides[0], sides[1], sides[2]));//todo name
                        string answer = _trianglesViwer.InputAnswer("Input answer <y> " +
                            "or <yes> if you want to continue:");//todo
                        canContinue = _currentCondition.CanContinue(answer);

                    } while (canContinue);

                    var result = _trianglesSorter.SortTriagleByDissending();
                    _trianglesViwer.ShowFigures(result);
                }
                catch (FormatException ex)
                {
                    isNeedRepeat = true;
                    _trianglesViwer.ShowMessage(ex.Message);
                    _trianglesViwer.ShowMessage(_insrtuction); // todo
                }
                catch (ArgumentNullException ex)
                {
                    isNeedRepeat = true;
                    _trianglesViwer.ShowMessage(ex.Message);
                    _trianglesViwer.ShowMessage(_insrtuction);
                }
                catch (ArgumentException ex)
                {
                    isNeedRepeat = true;
                    _trianglesViwer.ShowMessage(ex.Message);
                    _trianglesViwer.ShowMessage(_insrtuction);
                }

            } while (isNeedRepeat);
        }
    }
}
