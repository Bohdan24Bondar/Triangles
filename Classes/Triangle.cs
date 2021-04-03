using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class Triangle : IFigure
    {
        const double DEVIDER = 2.0;

        #region Private

        private string _name;
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        #endregion

        public Triangle(string name, double firstSide, double secondSide, 
                double thirdSide)
        {
            _name = name;
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public string Name 
        { 
            get
            {
                return _name;
            }
        }

        public double Square 
        {
            get
            {
                double halfPerimeter = HalfPerimeter;

                return Math.Sqrt(halfPerimeter * (halfPerimeter - _firstSide) 
                        * (halfPerimeter - _secondSide) 
                        * (halfPerimeter - _thirdSide));
            }
        }

        protected double HalfPerimeter
        {
            get
            {
                return (_firstSide + _secondSide + _thirdSide) / DEVIDER;
            }
        }

        public override string ToString()
        {
            return string.Format("[{0}] : {1}", _name, Square);
        }
    }
}
