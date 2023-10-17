using static System.Console;
using System.Text;
// Задача за използване на методи => 10 клас
namespace SFERA
{
    internal class Program
    {
        static double Surface(double X)
        {
            double Z = 4 * Math.PI * X * X;
            return Z;
        }
        static void PrintVolume(double V)
        {
            WriteLine($"Обема на сферата е {V:F2} куб. метра");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Write("Въведете радиуса на сферата R = ");
            float R = float.Parse(ReadLine());
            double V = Surface(R) * R / 3.0;
            double S = Surface(R);
            PrintVolume(V);
            WriteLine($"Лицето на сферата е {S} кв. метра");
        }
    }
}