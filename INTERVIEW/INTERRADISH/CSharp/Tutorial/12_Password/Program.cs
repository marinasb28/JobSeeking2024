using System;
using System.Text.RegularExpressions;

namespace Tutorial
{
    public class Password
    {
        public static bool isValid(string password)
        {
            // Minimum 8 characters
            if (password.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long.");
                return false;
            }

            // At least one lowercase letter
            if (!Regex.IsMatch(password, "[a-z]"))
            {
                Console.WriteLine("Password must include a lowercase letter.");
                return false;
            }

            // At least one uppercase letter
            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                Console.WriteLine("Password must include an uppercase letter.");
                return false;
            }

            // At least one number
            if (!Regex.IsMatch(password, "[0-9]"))
            {
                Console.WriteLine("Password must include a number.");
                return false;
            }

            // At least one special character (_@$)
            if (!Regex.IsMatch(password, "[_@$]"))
            {
                Console.WriteLine("Password must include a special character (_@$).");
                return false;
            }

            // Si cumple todas las condiciones
            return true;
        }

        public static void Main(string[] args)
        {
            bool valid;

            do
            {
                Console.Write("Enter a password: ");
                string passw = Console.ReadLine();
                valid = isValid(passw);

                if (!valid)
                {
                    Console.WriteLine("Invalid password. Please try again.");
                }
            } while (!valid);

            Console.WriteLine($"Password is valid! Access granted.\n{passw}");
        }
    }
}