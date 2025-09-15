
namespace GeometryLib
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public double R
        {
            get => _r;
            set
            {
                ValidateR(value);
                _r = value;
            }
        }

        public Circle(string name, double r ) : base(name) => R = r;

        public override double GetArea() => Math.PI * _r * _r;
        public override double GetPerimeter() => 2 * Math.PI * _r;

        private static void ValidateR(double r)
        {
            if (r <= 0) throw new ArgumentOutOfRangeException(nameof(r), "R must be > 0.");
        }
    }
}
