
namespace GeometryLib
{
    public class Square : GeometricFigure
    {
        private double _a;

        public double A
        {
            get => _a;
            set
            {
                ValidateA(value);
                _a = value;
            }
        }

        public Square(string name,double a) : base(name) => A = a;

        public override double GetArea() => _a * _a;
        public override double GetPerimeter() => 4 * _a;

        private static void ValidateA(double a)
        {
            if (a <= 0) throw new ArgumentOutOfRangeException(nameof(a), "Side A must be > 0.");
        }
    }
}
