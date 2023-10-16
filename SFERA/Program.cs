using static System.Console;
using System.Text;
namespace SFERA
{
    internal class Program
    {
        static double Surface(double X)
        {
            double Z = 4 * Math.PI * X * X;
            return Z;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Write("Въведете радиуса на сферата R = ");
            float R = float.Parse(ReadLine());
            double V = Surface(R) * R / 3.0;
            double S = Surface(R);
            WriteLine($"Обема на сферата е {V} куб. метра");
            WriteLine($"Лицето на сферата е {S} кв. метра");
        }
    }
}