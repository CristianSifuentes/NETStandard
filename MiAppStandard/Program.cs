using MyStandardLibrary;
using System;

class Program {
    static void Main(){
        //Write once, run anywhere
        //A library that targets .NET Standard can be used on all 
        //Code Sharing, Platform Independence and API consistency
        Console.WriteLine($"Subtraction: { MyMathematics.Subtraction(5, 3) }");
        Console.WriteLine($"Addition: {MyMathematics.Addition(5, 3)}");

    }
}