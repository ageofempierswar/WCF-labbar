using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
namespace Labb_2_Service_och_tjänsten
{
    class Program
    {
        [ServiceContract(Namespace = "http://EcUtbildning.Labb_2_Service_och_tjänsten")]
        public interface IBMICalculator
        {
            [OperationContract]// Måste finnas för varje medtod för att det ska följa med i WCF kontraktet
            int BMICalc(int BMICalc);

        }
        static void Main(string[] args)
        {
        }
    }
}
