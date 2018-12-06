using System;

namespace GeometricFiguresLibrary
{
    public class Circle : GeometricFigure
    {
        public double Radius { get { return _radius; } set { _radius = value; } }
        
        private double _radius;

        public Circle() : this(0) { }

        public Circle(double radius)
        { this._radius = radius; }

        new public double Perimeter()
        { return 2 * _radius * Math.PI; }

        new public double Square()
        { return _radius * _radius * Math.PI; }
    }
}
