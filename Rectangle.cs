using System;

namespace MTD_Laba_2
{
    public class Rectangle
    {
        public int _width;
        public int _height;
        public Rectangle(int w, int h)
        {
            _width = w;
            _height = h;
        }

        public Rectangle Clone()
        {
            return new Rectangle(_width, _height);
        }
        public void GetInfo()
        {
            Console.WriteLine($"Rectangle height {_height} and width {_width}");
        }
    }
}