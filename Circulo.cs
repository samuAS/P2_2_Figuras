using System.Drawing;

namespace P2_2_Figuras
{



    internal class Circulo : Figura
    {
        private double _radio;

        public Circulo(Color color, double radio) : base(color)
        {
            _radio = radio;
        }

        public double Radio
        {
            get { return _radio; }
            set { _radio = value; }
        }

        public override double GetArea()
        {
            return Math.PI * _radio * _radio;
        }

        public override string ToString()
        {
            return base.ToString() + $"Radio: {_radio}\nArea: {GetArea()}\n";
        }
    }


}
