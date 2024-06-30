using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic4_5
{
    internal class task18
    {

class Program
    {
        // Predefined user data (username, password)
        static (string, string)[] predefinedUsers = {
        ("alice", "password123"),
        ("bob", "securePass"),
        ("charlie", "secret123")
    };

        static bool ValidateLogin(string username, string password)
        {
            foreach (var (user, pass) in predefinedUsers)
            {
                if (user == username && pass == password)
                {
                    return true; // Successful login
                }
            }
            return false; // Failed login
        }

        static void Main()
        {
            Console.Write("Enter username: ");
            string inputUsername = Console.ReadLine();

            Console.Write("Enter password: ");
            string inputPassword = Console.ReadLine();

            bool isLoggedIn = ValidateLogin(inputUsername, inputPassword);

            if (isLoggedIn)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Login failed. Invalid username or password.");
            }
        }
    }

}
}
