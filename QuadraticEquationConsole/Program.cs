using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationConsole
{

    class QuadraticEquationHelper
    {
        public static int calculateDiscriminant(int a, int b, int c)
        {
            int discriminant = b * b - 4 * a * c;
            return discriminant;
        }

        public static double calculateX1(int a, int b, int discriminant)
        {
            return (-b + Math.Sqrt(discriminant)) / 2 * a;
        }

        public static double calculateX2(int a, int b, int discriminant)
        {
            return (-b - Math.Sqrt(discriminant)) / 2 * a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Enter a:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            c = Int32.Parse(Console.ReadLine());

            int discriminant = QuadraticEquationHelper.calculateDiscriminant(a, b, c);

            Console.WriteLine("Discriminant= "+ discriminant);

            double x1 = QuadraticEquationHelper.calculateX1(a, b, discriminant);
            double x2 = QuadraticEquationHelper.calculateX2(a, b, discriminant);

            Console.WriteLine("X1 = "+ x1);
            Console.WriteLine("X2 = "+ x2);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
