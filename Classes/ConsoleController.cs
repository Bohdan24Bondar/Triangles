using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FigureLibrary;

namespace TriangleTask
{
    class ConsoleController
    {

        #region Consts

        public const string COMMON_NAME = "Triangle";

        #endregion

        #region Private

        private string _insrtuction;
        private Viewer _figuresViwer;
        private IContinueChecker _checker;
        private INumbericsValidator _numbericsCheker;
        private IFigureContainer _figuresContainer;
        private IFigureValidator _figuresChecker;
        private FigureFactory _figureBuilder;
        private IComparer<IFigure> _figuresComparer;

        #endregion

        public ConsoleController(string instruction, IContinueChecker checkerProcess, 
                INumbericsValidator numbericsCheker, IFigureContainer figuresContainer,
                IFigureValidator figuresChecker, TriangleFactory figureBuilder, 
                IComparer<IFigure> figuresComparer)
        {
            _figuresViwer = new Viewer("Please input parameters of triangle" +
                   " as said in the instruction:", instruction); //todo instruction 
            _checker = checkerProcess;
            _numbericsCheker = numbericsCheker;
            _figuresContainer = figuresContainer;
            _figuresChecker = figuresChecker;
            _figureBuilder = figureBuilder;
            _figuresComparer = figuresComparer;
            _insrtuction = instruction;

        }

        public void Run()
        {
            try
            {
                bool canContinue = true;
                string[] arguments;

                do
                {
                    arguments = _figuresViwer.InputParameters();

                    if (!_numbericsCheker.IsNumber(arguments[1], arguments[2], arguments[3]))
                    {
                        return;
                    }

                    double[] sides = GetNumbers(arguments[1],
                            arguments[2], arguments[3]);

                    if (!_figuresChecker.HasRightSides(sides) 
                            || !_figuresChecker.IsRightName(arguments[0], COMMON_NAME))
                    {
                        return;
                    }

                    _figuresContainer.AddFigure(_figureBuilder.Create(arguments[0], sides));

                    string answer = _figuresViwer.InputAnswer("Input answer <y> " +
                        "or <yes> if you want to continue:");//todo
                    canContinue = _checker.CanContinue(answer);

                } while (canContinue);

                IFiguresSorter trianlgleSorter = GetFigureSorter(_figuresContainer.GetFigures(), 
                        _figuresComparer);
                var result = trianlgleSorter.SortFigures();
                _figuresViwer.ShowFigures(result);
            }
            catch (FormatException ex)
            {
                _figuresViwer.ShowMessage(ex.Message);
                _figuresViwer.ShowMessage(_insrtuction); // todo
            }
        }

        private IFiguresSorter GetFigureSorter(IEnumerable<IFigure> plentyFigures, 
                IComparer<IFigure> figuresComparer)
        {
            FiguresSorterByDescendingFactory creator = new FiguresSorterByDescendingFactory(plentyFigures, 
                    figuresComparer);

            return creator.Create();
        }

        private double [] GetNumbers(params string[] sides)
        {
            NumbericConvertor sidesConvertor = new NumbericConvertor(sides);
            double[] figureSides = new double[sides.Length];
            sidesConvertor.GetNumbers(out figureSides);

            return figureSides;
        }
    }
}
