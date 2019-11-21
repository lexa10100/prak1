using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Hello();
            Reshenie(a, b, c);
            Console.WriteLine(Raznost(a, b, c));
            Console.ReadKey();
        }
        static void Hello()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine((a + 4 * b - Math.Sqrt(123)) / (1 - c / 2));
        }
        static void Reshenie(double a, double b, double c) => Console.WriteLine((a + 4 * b - Math.Sqrt(123)) / (1 - c / 2));
        static double Raznost(double a, double b, double c)
        {
            return (a + 4 * b - Math.Sqrt(123)) / (1 - c / 2);
        }
    }
}

