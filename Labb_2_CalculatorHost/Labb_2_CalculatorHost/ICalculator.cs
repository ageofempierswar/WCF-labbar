using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
namespace Labb_2_CalculatorHost
{
    [ServiceContract(Namespace = "http://Christopher.CalculatorHost")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double a, double b);
        [OperationContract]
        double Subtract(double a, double b);
        [OperationContract]
        double Multiply(double a, double b);
        [OperationContract]
        double Divide(double a, double b);
    }
}
