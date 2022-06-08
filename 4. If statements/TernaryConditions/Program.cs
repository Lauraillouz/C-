using System;

namespace TernaryConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = 120;
            string stateOfMatter;

            stateOfMatter = temperature < 0 ? "solid" : (temperature > 100 ? "gas" : "liquid");

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            int temperatureValue;

            Console.WriteLine("Enter a temperature");
            string tempInput = Console.ReadLine();

            bool isTempValid = int.TryParse(tempInput, out temperatureValue);
            string message;

            if (isTempValid)
            {
                message = temperatureValue <= 15 ? "it's too cold" : (temperatureValue >= 16 && temperatureValue <= 28 ? "it's ok" : "it's too hot");
            }
            else
            {
                message = "Not a valid temperature";
            }

            Console.WriteLine(message);
            Console.Read();
        }

        public static void CheckTemperature(int temp)
        {

        }
    }
}
