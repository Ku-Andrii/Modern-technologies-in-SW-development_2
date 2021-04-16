using System;

namespace MTD_Laba_2
{
    public class Circle
    {
        public int _radius;
        public Circle(int r)
        {
            _radius = r;
        }

        public Circle Clone()
        {
            return new Circle(_radius);
        }
        public void GetInfo()
        {
            Console.WriteLine($"Circle with radius {_radius}");
        }
    }
}