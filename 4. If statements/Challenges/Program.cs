using System;

namespace Challenges
{
    class Program
    {


        static void Main(string[] args)
        {
            bool isRegistered = false;
            bool isLoggedIn = false;
            bool isUserNameValid = false;
            bool isPasswordValid = false;
            string userName = "";
            string password = "";
            string userNameInput = "";
            string passwordInput = "";

            // Ask to register
            Console.WriteLine("Enter your username: ");
            userName = Console.ReadLine();
            Console.WriteLine("Choose a password: ");
            password = Console.ReadLine();

            // Send method to return isRegistered true and success message
            Register(isRegistered); 
            isRegistered = Register(isRegistered);

            // Ask for login
            if (isRegistered)
            {
                Console.WriteLine("You are successfully registered.");
                Console.WriteLine("To log in, enter your username: ");
                userNameInput = Console.ReadLine();
                CheckUserName(isUserNameValid);

                if (userNameInput == userName)
                {
                    Console.WriteLine("Now enter your password: ");
                    passwordInput = Console.ReadLine();
                    CheckPassword(isPasswordValid);
                } else
                {
                    Console.WriteLine("Invalid username, try again.");

                }

                if (password == passwordInput)
                {
                    Login(isLoggedIn);
                    Console.WriteLine("You are successfully logged in.");
                }
                else
                {
                    Console.WriteLine("Your password is incorrect, try again");

                }

            }
            Console.WriteLine("Thanks!");

        }

        public static bool Register(bool isRegistered)
        {
            return isRegistered = true;            
        }

        public static bool CheckUserName (bool isUserNameValid)
        {
            return isUserNameValid = true;
        }

        public static bool CheckPassword (bool isPasswordValid)
        {
            return isPasswordValid = true;
        }

        public static bool Login (bool isLoggedIn)
        {
            return isLoggedIn = true;

        }
    }
}
