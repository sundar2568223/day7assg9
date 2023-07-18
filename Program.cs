using System;
namespace day7ass9
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("User Registration");
                Console.WriteLine("------------------------");
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your email: ");
                string email = Console.ReadLine();
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
                // Validate input
                ValidateInput(name, email, password);
                // If input is valid, display success message and registration details
                Console.WriteLine("User registration successful!");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Email: " + email);
                Console.WriteLine("Password: " + password);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine("Validation error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        private static void ValidateInput(string name, string email, string password)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                throw new ValidationException("All fields are required.");
            }
            if (name.Length < 6)
            {
                throw new ValidationException("Name must have at least 6 characters.");
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new ValidationException("Invalid email format.");
            }
            if (password.Length < 8)
            {
                throw new ValidationException("Password must have at least 8 characters.");
            }
        }
    }
}
