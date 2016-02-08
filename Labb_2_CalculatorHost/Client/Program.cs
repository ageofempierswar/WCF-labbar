using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client Connecting...");
            CalculatorClient client = new CalculatorClient();
            client.Open();

            Console.Write("Adding 2 + 2 - Answer: ");
            Console.WriteLine(client.Add(2, 2));

            Console.Write("Subtracting 2 - 2 - Answer: ");
            Console.WriteLine(client.Subtract(2, 2));

            Console.Write("Dividing 2 / 2 - Answer: ");
            Console.WriteLine(client.Divide(2, 2));

            Console.Write("Multiplying 2 * 2 - Answer: ");
            Console.WriteLine(client.Multiply(2, 2));

            client.Close();
            Console.ReadLine();
        }
    }
}
