﻿using CycloidGenerator.Solvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CycloidGenerator
{
    public interface IExportClient
    {
        void Circle(SolverPoint center, double radius, int color, string layer);
        void Line(SolverPoint p1, SolverPoint p2, int color, string layer);
        void Spline(IList<SolverPoint> points, int color, string layer);
        void Point(SolverPoint p1, int color, string layer);
    }
}
