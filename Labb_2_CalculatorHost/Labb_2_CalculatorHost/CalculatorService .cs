using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
namespace Labb_2_CalculatorHost
{
    
    class CalculatorService:ICalculator
    {
        public double Add(double a, double b)
        {
           return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            if (a !=0 || b !=0)
            {
                return a / b;
            }
            else
            {
                return 0;
            }
        }
    }
}
