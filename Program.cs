/*
    Разработать метод для решения системы 2 линейных
    уравнений:
    A1×X + B1×Y = 0
    A2×X + B2×Y = 0
    Метод с помощью выходных параметров должен
    возвращать найденное решение или ошибку, если
    решения не существует.
*/
using System;

namespace CSharpHomeCase5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=0, y=0;
            bool result = false;
            int a1 = -0, b1 = 0, a2 = 0, b2 = 0;
            Console.WriteLine("A1×X + B1×Y = 0\nA2×X + B2×Y = 0\n");
            Console.Write("Enter A1:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B1:");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter A2:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B2:");
            a1 = Convert.ToInt32(Console.ReadLine());

            Solve(a1, b1, a2, b2, x, y, result);

            if (result)
            {
                Console.WriteLine("x = " + x + ";\ny = " + y + ";");
            }
            else
            {
                Console.WriteLine("\nError! Solution is not existing.");
            }

            Console.ReadKey();
        }

        private static void Solve(int a1, int b1, int a2, int b2,
            double x, double y, bool result)
        {
            if (a1 == 0 && b1 == 0 && (a2 != 0 || b2 != 0))
                Console.WriteLine("Warning: First line is not existing.");
            else if ((a1 != 0 || b1 != 0) && a2 == 0 && b2 == 0)
                Console.WriteLine("Warning: Second line is not existing.");
            else if (a1 == 0 && b1 == 0 && a2 == 0 && b2 == 0)
                Console.WriteLine("Warning: Both lines are not existing.");
            else if (a1 == a2 && b1 == b2)
                Console.WriteLine("Warning: The lines are coincident.");
            else if (a1 * b2 == b1 * a2)
                Console.WriteLine("Warning: The lines are coincident.");
            else
                x = y = 0;
        }
    }
}
