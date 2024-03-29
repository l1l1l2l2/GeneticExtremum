﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GeniticExt.Problems.Example
{
    public class ConcreteProblem : Problem
    {
        private double Func(double[] args)
        {
            return 100 * Math.Pow(Math.Pow(args[0], 2) - Math.Pow(args[1], 2), 2) + Math.Pow(1 - args[0], 2);
        }

        public ConcreteProblem()
        {
            Function = Func;
            SearchArea = new SearchArea(-2.048, 2.048);
            ExtrDirection = ExtremumDirection.Minimum;
        }
    }
}
