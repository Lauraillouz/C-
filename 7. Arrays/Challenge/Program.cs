using System;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int intInput;

            string[] dataType = { "String", "Integer", "Boolean" };
            int counter = 1;

            Console.WriteLine("Please enter a value: ");
            string input = Console.ReadLine();
            Console.WriteLine("Select the Data type to validate the input you have enetered");

            foreach(string type in dataType)
            {
                Console.WriteLine("Press {0} for {1}", counter, type);
                counter++;
            }
            string dataTypeInput = Console.ReadLine();

            switch(dataTypeInput)
            {
                case "2":
                    if(int.TryParse(input, out intInput)) {
                        Console.WriteLine("You have entered the number {0}", intInput);
                        Console.WriteLine("It is a valid {0}", dataType[1]);
                    }
                    else
                    {
                        Console.WriteLine("You have entered the number {0}", input);
                        Console.WriteLine("It is an invalid {0}", dataType[1]);
                    }
                    break;
                case "3":
                    if(input == "true" || input == "false")
                    {
                        Console.WriteLine("You have entered {0}", input);
                        Console.WriteLine("It is a valid {0}", dataType[2]);
                    }
                    else
                    {
                        Console.WriteLine("You have entered {0}", input);
                        Console.WriteLine("It is an invalid {0}", dataType[2]);
                    }
                    break;
                case "1":
                    if(!int.TryParse(input, out intInput) && input != "true" && input != "false")
                    {
                        Console.WriteLine("You have entered {0}", input);
                        Console.WriteLine("It is a valid {0}", dataType[0]);

                    }
                    else
                    {
                        Console.WriteLine("You have entered {0}", input);
                        Console.WriteLine("It is an invalid {0}", dataType[0]);
                    }
                    break;

            }           

        }
    }
}
