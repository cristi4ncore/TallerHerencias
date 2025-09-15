
using System.Xml.Linq;

namespace GeometryLib
{
    public class Rhombus : Square
    {
        private double _d1, _d2;

        public double D1
        {
            get => _d1;
            set
            {
                ValidateD1(value);
                _d1 = value;
            }
        }

        public double D2
        {
            get => _d2;
            set
            {
                ValidateD2(value);
                _d2 = value;
            }
        }

        public Rhombus(string name, double a, double d1, double d2)
     : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        public override double GetArea() => (_d1 * _d2) / 2;
        public override double GetPerimeter() => 4 * A;

        private static void ValidateD1(double d1)
        {
            if (d1 <= 0) throw new ArgumentOutOfRangeException(nameof(d1), "D1 must be > 0");
        }
        private static void ValidateD2(double d2)
        {
            if (d2 <= 0) throw new ArgumentOutOfRangeException(nameof(d2), "D2 must be > 0");
        }
    }
}
