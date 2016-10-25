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

        Operation[] GetOperations();

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

        public Operation[] GetOperations()
        {
            return new Operation[]
            {
                new Operation(){Name = "Sum", ParameterCount = 2},
                new Operation(){Name = "Divide", ParameterCount = 2},
                new Operation(){Name = "Differ", ParameterCount = 2},
                new Operation(){Name = "Multiple", ParameterCount = 2},
                new Operation(){Name = "Stepen", ParameterCount = 2},
                new Operation(){Name = "Koren", ParameterCount = 2},
                new Operation(){Name = "Ostatok", ParameterCount = 2},
            };
        }
    }

    public class Operation
    {
        public string Name { get; set; }

        public int ParameterCount { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
    

