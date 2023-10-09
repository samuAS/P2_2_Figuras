//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
using _P2_2_Figuras;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {
    Rectangulo rectangulo = new Rectangulo(Color.FromArgb(255, 50, 20, 34), 3, 3.9);
    Circulo circulo1 = new Circulo(Color.FromArgb(255, 0, 20, 35), 4);
    Circulo circulo2 = new Circulo(Color.FromArgb(255, 230, 20, 30), 2);
    TrianguloEquilatero triangulo = new TrianguloEquilatero(Color.FromArgb(255, 0, 20, 40), 3);

    Console.WriteLine(rectangulo);
    Console.WriteLine(circulo1);
    Console.WriteLine(circulo2);
    Console.WriteLine(triangulo);

    List<Figura> lista_figuras = new List<Figura>
            {
                rectangulo,circulo1,circulo2,triangulo,
                new Rectangulo(Color.FromArgb(255, 100, 50, 20), 5, 6),
                new TrianguloEquilatero(Color.FromArgb(255, 0, 255, 0), 4)
            };
  }


}