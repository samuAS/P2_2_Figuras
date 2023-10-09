

using System.Drawing;
using P2_2_Figuras;

namespace _P2_2_Figuras
{

    internal class TrianguloEquilatero : Figura
    {
        private double _lado;

        public TrianguloEquilatero(Color color, double lado) : base(color)
        {
            _lado = lado;
        }

        public double Lado
        {
            get { return _lado; }
            set { _lado = value; }
        }

        public override double GetArea()
        {
            return (_lado * _lado * Math.Sqrt(3)) / 4;
        }

        public override string ToString()
        {
            return base.ToString() + $"Lado: {_lado}\nArea: {GetArea()}\n";
        }
    }
}