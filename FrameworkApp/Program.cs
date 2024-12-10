using MathLibrary;
using System;

namespace FrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //error NU1201: Project MathLibrary is not compatible with net40 (.NETFramework,Version=v4.0). Project MathLibrary supports: netstandard1.0 (.NETStandard,Version=v1.0)
             Console.WriteLine("Calculating the derivative of the function f(x) = x^2 at x = 3");
             // Function f(x) = x^2
             Fun<double, double> function = x => x * x;
             // Calculate the derivate at x = 3
             double derivate = NumericalDifferentiation.Differentiate(function, 3);
             Console.WriteLine($"The derivative of f(x) = x^2 at x = 3 is: {derivative}");
        }
    }
}
