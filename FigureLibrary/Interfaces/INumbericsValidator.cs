﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public interface INumbericsValidator
    {
        bool IsNumber(params string[] numbers);
    }
}
