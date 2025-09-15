

using System.Xml.Linq;

namespace GeometryLib
{
    public class Kite : Rhombus
    {
        private double _b;

        public double B
        {
            get => _b;
            set
            {
                ValidateB(value);
                _b = value;
            }
        }

        public Kite(string name,double a, double d1, double d2, double b)
            : base(name, a, d1, d2) => B = b;

       
        public override double GetArea() => D1 * D2 /2;
        
        public override double GetPerimeter() => 2 * (A + _b);

        private static void ValidateB(double b)
        {
            if (b <= 0) throw new ArgumentOutOfRangeException(nameof(b), "B must be > 0");
        }
    }
}
