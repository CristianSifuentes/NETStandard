using System;

namespace MathLibrary
{
    public static class NumericalDifferentiation
    {
        public static double Differentiate(System.Func<double, double> function, double x, double h = 1e-5){
            return (function(x + h) - function(x - h)) / (2 * h);
        }


    }
}
