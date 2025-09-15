

namespace GeometryLib
{
    public class Triangle : Rectangle
    {
        private double _c; 
        private double _h; 

        public double C
        {
            get => _c;
            set
            {
                ValidateC(value);
                _c = value;
                
            }
        }

        public double H
        {
            get => _h;
            set
            {
                ValidateH(value);
                _h = value;
            }
        }

        public Triangle(string name,double a, double b, double c, double h)
            : base(name,a, b)
        {
            _c = c; _h = h;
            ValidateC(_c);
            ValidateH(_h);
            
        }

       
        public override double GetArea() => B * _h / 2;
        public override double GetPerimeter() => A + B + _c;

        private static void ValidateC(double c)
        {
            if (c <= 0) throw new ArgumentOutOfRangeException(nameof(c), "Side C must be > 0.#####");
        }

        private static void ValidateH(double h)
        {
            if (h <= 0) throw new ArgumentOutOfRangeException(nameof(h), "Height H must be > 0.#####");
        }

        
    }
}
