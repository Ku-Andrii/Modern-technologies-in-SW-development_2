using System;

namespace MTD_Laba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = new Rectangle(30, 40);
            var clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            var figur = new Circle(30);
            var clonedFigur = figur.Clone();
            figur.GetInfo();
            clonedFigur.GetInfo();

            Console.Read();
        }
    }
}