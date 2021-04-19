using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public abstract class FigureFactory
    {
        //#region Protected

        //protected double[] _sides;
        //protected string _name;
        
        //#endregion

        //public FigureFactory(string name , params double[] sides)
        //{
        //    _name = name;
        //    _sides = sides;
        //}

        public abstract IFigure Create(string name, params double[] sides);

    }
}
