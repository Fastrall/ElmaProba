using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public interface ICalculator
    {
        int Sum(int x, int y);

        int? Divide(int x, int y);
    }

    public class Calculator : ICalculator
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int? Divide(int x, int y)
        {
            if (y == 0)
            {
                return null;
            }

            return x / y;
        }
        public double Differ(double x, double y)
        {
            return x - y;
        }

        public double Multiple(double x, double y)
        {
            return x * y;
        }

        public double Stepen(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public double Koren(double x, double y)
        {
            return Math.Pow(x, 1 / y);
        }

        public double Ostatok(double x, double y)
        {
            return x % y;
        }

        public string[] Methods()
        {
            return new[] { "Sum", "Divide", "Differ", "Multiple", "Stepen", "Koren", "Ostatok" };
        }
    }
}
