

using System.Xml.Linq;

namespace GeometryLib
{
    public class Rectangle : Square
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

        public Rectangle(string name,double a, double b) : base(name,a) => B = b;

        public override double GetArea() => A * _b;
        public override double GetPerimeter() => 2 * (A + _b);

        private static void ValidateB(double b)
        {
            if (b <= 0) throw new ArgumentOutOfRangeException(nameof(b), "Side B must be > 0.#####");
        }
    }
}
