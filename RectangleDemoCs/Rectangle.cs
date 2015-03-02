using System;
using RectangleDemoCs.Interfaces;

namespace RectangleDemoCs
{
    public class Rectangle : IShape
    {
        public decimal Length { get; private set; }
        public decimal Width { get; private set; }

        public Rectangle(decimal length, decimal width)
        {
            if (length <= 0) throw new ArgumentOutOfRangeException("length", "length must be positve");
            if (width <= 0) throw new ArgumentOutOfRangeException("width", "width must be positve");
            
            Length = length;
            Width = width;
        }

        public decimal Area
        {
            get { return Length * Width; }
        }

        public decimal Perimeter
        {
            get { return (Length * 2) + (Width * 2); }
        }

        public bool IsSquare()
        {
            return Length == Width;
        }
    }
}
