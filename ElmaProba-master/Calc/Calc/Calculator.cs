using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public interface ICalculator
    {
        double Sum(double x, double y);

        double? Divide(double x, double y);

        double Differ(double x, double y);

        double Multiple(double x, double y);

        double Stepen(double x, double y);

        double Koren(double x, double y);

        double Ostatok(double x, double y);

    }

    public class Calculator : ICalculator
    {
        public double Sum(double x, double y)
        {
            return x + y;
        }

        public double? Divide(double x, double y)
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
            return new[] {"Sum", "Divide", "Differ", "Multiple", "Stepen", "Koren", "Ostatok" };
        }
    }
}
