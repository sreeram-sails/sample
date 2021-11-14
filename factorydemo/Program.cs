using factorydemo.factory;
using System;

namespace factorydemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ShapeGenerator shapeGenerator = new ShapeGenerator();
           IShape shape1= shapeGenerator.GetShape("SQUARE");
            shape1.Draw();
        }
    }
}
