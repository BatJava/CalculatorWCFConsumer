using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorWCFConsumer.ServiceReference1;

namespace CalculatorWCFConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string endpointConfigurationName = "BasicHttpBinding_IService1";
            ServiceReference1.Service1Client service1 = new Service1Client(endpointConfigurationName);

            // Alternatively, as there is only one ConfigurationName in the app.config file just use
            //ServiceReference1.Service1Client service1 = new Service1Client();

            Console.WriteLine("State first number; ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("State second number; ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = service1.add(a, b);
            Console.WriteLine("Sum: "+ sum);

            int dif = service1.sub(a, b);
            Console.WriteLine("Subtraction: " + dif);

            int prod = service1.mul(a, b);
            Console.WriteLine("Multiplication " + prod);

            double div = service1.div(a, b);
            Console.WriteLine("Division: " + div);

          // List<String> names = service1.names(); //cannot convert to List <String>
           String[] names = service1.names();
            for (int i = 0; i < names.Length; i++)
             Console.WriteLine(names[i]);
        }
    }
}
