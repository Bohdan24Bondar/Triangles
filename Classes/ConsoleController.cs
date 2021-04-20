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
        #region Private

        private string _insrtuction;
        private IViewer _figuresViwer;
        private IContinueChecker _checker;
        private INumbericsValidator _numbericsCheker;
        private IFigureValidator _figuresChecker;
        private FigureFactory _figureBuilder;
        private IComparer<IFigure> _figuresComparer;
        private FiguresSorterByDescendingFactory _sorterFactory;
        private Queue<IFigure> _figuresContainer;

        #endregion

        public ConsoleController(string instruction, IContinueChecker checkerProcess, 
                INumbericsValidator numbericsCheker, IFigureValidator figuresChecker, 
                TriangleFactory figureBuilder, IComparer<IFigure> figuresComparer, 
                FiguresSorterByDescendingFactory sorterFactory, IViewer figuresViwer)
        {
            _insrtuction = instruction;
            _checker = checkerProcess;
            _numbericsCheker = numbericsCheker;
            _figuresChecker = figuresChecker;
            _figureBuilder = figureBuilder;
            _figuresComparer = figuresComparer;
            _sorterFactory = sorterFactory;
            _figuresViwer = figuresViwer;
            _figuresContainer = new Queue<IFigure>();
        }

        public void Run()
        {
            try
            {
                bool canContinue = true;
                _figuresViwer.ShowMessage(_insrtuction);

                do
                {
                    string[] arguments = _figuresViwer.InputParameters();

                    if (!_numbericsCheker.IsNumber(arguments[1], arguments[2], arguments[3]))
                    {
                        string message = string.Format("{0}\n{1}",
                                DefaultSettings.WRONG_FORMAT_ARGS, _insrtuction);
                        _figuresViwer.ShowMessage(message);
                        return;
                    }

                    double[] sides = GetNumbers(arguments[1], arguments[2], arguments[3]);

                    if (!_figuresChecker.IsRightName(arguments[0], DefaultSettings.COMMON_NAME) 
                            || !_figuresChecker.HasRightSides(sides))
                    {
                        string message = string.Format("{0}\n{1}",
                                DefaultSettings.WRONG_FIGURES_ARGS, _insrtuction);
                        _figuresViwer.ShowMessage(message);
                        return;
                    }

                    _figuresContainer.Enqueue(_figureBuilder.Create(arguments[0], sides));
                    string answer = _figuresViwer.InputAnswer(DefaultSettings.ANSWER_MESSAGE);
                    canContinue = _checker.CanContinue(answer);

                } while (canContinue);

                if (_figuresContainer.Count == 0)
                {
                    _figuresViwer.ShowMessage(_insrtuction);
                    return;
                }

                IFiguresSorter trianlgleSorter = _sorterFactory.Create(_figuresContainer,
                        _figuresComparer);
                IEnumerable<IFigure> figures = trianlgleSorter.SortFigures();
                _figuresViwer.ShowFigures(figures);
            }
            catch(NullReferenceException ex)
            {
                string message = string.Format("{0}\n{1}",ex.Message, _insrtuction);
                _figuresViwer.ShowMessage(message);
            }
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
