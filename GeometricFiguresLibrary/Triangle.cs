using System;

namespace GeometricFiguresLibrary
{
    public class Triangle : GeometricFigure
    {
        public double A { get { return _a; } set { _a = value; } }
        public double B { get { return _b; } set { _b = value; } }
        public double C { get { return _c; } set { _c = value; } }

        private double _a;
        private double _b;
        private double _c;

        public Triangle() : this(1, 1, 1) { }

        public Triangle(double a, double b, double c)
        {
            if (CheckSide(a, b, c))
            {
                this._a = a;
                this._b = b;
                this._c = c;
            }
            else { throw new ArgumentOutOfRangeException("Введенные стороны не позволят сформировать треугольник."); }
        }

        new public double Perimeter()
        { return this._a + this._b + this._c; }

        new public double Square()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsRightTriangle()
        {
            double hypotenuse, leg1, leg2;

            if (_a > _b && _a > _c)
            { hypotenuse = _a; leg1 = _b; leg2 = _c; }
            else if (_b > _a && _b > _c)
            { hypotenuse = _b; leg1 = _a; leg2 = _c; }
            else
            { hypotenuse = _c; leg1 = _a; leg2 = _b; }

            return hypotenuse * hypotenuse == leg1 * leg1 + leg2 * leg2;
        }

        private bool CheckSide(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 &&
                a < b + c &&
                b < a + c &&
                c < a + b;
        }
    }
}
