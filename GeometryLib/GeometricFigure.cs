namespace GeometryLib
{
    public abstract class GeometricFigure
    {
        private string _name = string.Empty;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name must be non-empty.", nameof(value));
                _name = value.Trim();
            }
        }

        protected GeometricFigure(string name) => Name = name;

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString() =>
            $"{Name, -15} =>   Area: {GetArea(), 12:F5}    Perimeter: {GetPerimeter(),12:F5}";
    }
}
