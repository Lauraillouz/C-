using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // define few variables
            int age = 31;
            string name = "Alfonso";
            string address = "35, quai de l'ourcq";

            // string formatting
            Console.WriteLine("String formatting");
            Console.WriteLine("Hello, my name is {0}, I am {1} and I live in {2}", name, age, address);

            // string interpollation
            Console.WriteLine("String interpollation");
            Console.WriteLine($"Hello, my name is {name}, I am {age} and I live in {address}");

            // Verbatim strings
            Console.WriteLine("Verbatim strings: takes into consideration any spaces and escapes. Is very useful to write paths without the code considering the backslash is an escape caracter");
            Console.WriteLine(@"C:\User\something\etc");

            // Challenge 1
            string userName;

            Console.WriteLine("Please enter your name and press enter");
            userName = Console.ReadLine();
            Console.WriteLine("This is your name in uppercase: {0}", userName.ToUpper());
            Console.WriteLine("This is your name with no white space: {0}", userName.Trim());
            Console.WriteLine("this is your name from the 3rd letter: {0}", userName.Substring(2));
            Console.Read();

            // Challenge 2
            string userString;
            string letterToSearch;
            string firstName;
            string lastName;
            string fullName;

            Console.WriteLine("Enter a string here: ");
            userString = Console.ReadLine();
            Console.WriteLine("Enter the character to search in your string");
            letterToSearch = Console.ReadLine();
            Console.WriteLine("The letter you search is in position {0}", userString.IndexOf(letterToSearch));
            Console.WriteLine("Please now enter your first name and press enter");
            firstName = Console.ReadLine();
            Console.WriteLine("Thanks. Now enter your last name and press enter");
            lastName = Console.ReadLine();
            fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine("Your full name is {0}", fullName);

        }
    }
}
