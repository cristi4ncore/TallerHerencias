
namespace GeometryLib
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public double H
        {
            get => _h;
            set
            {
                ValidateH(value);
                _h = value;
            }
        }

        public Parallelogram(string name,double a, double b, double h)
            : base(name,a, b) => H = h;

        public override double GetArea() => B * _h;            
        public override double GetPerimeter() => 2 * (A + B);  

        private static void ValidateH(double h)
        {
            if (h <= 0) throw new ArgumentOutOfRangeException(nameof(h), "H must be > 0");
        }
    }
}
