using System;

namespace Quadratic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quadratic Equation");
            (double a, double b, double c) = GetAbc();

            (double x1, double x2) = GetQuadratic(a, b, c);
            Console.WriteLine($"Solution 1: {x1}");
            Console.WriteLine($"Solution 2: {x2}");
        }

        static double GetValue(string prompt)
        {
            Console.WriteLine(prompt);
            double result = double.Parse(Console.ReadLine());
            return result;
        }

        static (double, double, double) GetAbc()
        {
            double a = GetValue("A: ");
            double b = GetValue("B: ");
            double c = GetValue("C: ");
            return (a, b, c);
        }

        static (double, double) GetQuadratic(double a, double b, double c)
        {
            double x1 = (-b + Math.Sqrt(b * b - 4.0 * a * c)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(b * b - 4.0 * a * c)) / (2.0 * a);
            return ( x1 , x2 );
        }
    }
}
