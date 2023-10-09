

using System.Drawing;
using P2_2_Figuras;

namespace _P2_2_Figuras
{

    internal class Rectangulo : Figura
    {
        private double _base;
        private double _altura;

        public Rectangulo(Color color, double @base, double altura) : base(color)
        {
            _base = @base;
            _altura = altura;
        }

        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public double Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public override double GetArea()
        {
            return _base * _altura;
        }

        public override string ToString()
        {
            return base.ToString() + $"Base: {_base}\nAltura: {_altura}\nArea: {GetArea()}\n";
        }
    }

}