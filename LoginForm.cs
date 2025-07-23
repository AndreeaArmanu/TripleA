using registerApp;
using System;
using System.Linq;

namespace registerApp
{
    public class LoginForm
    {
        private Manager _manager;

        public LoginForm(Manager manager)
        {
            _manager = manager;
        }

        public void Show()
        {
            Console.Clear();
            Console.WriteLine("Login");

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            User user = Validate(username, password);
            if (user != null)
            {
                Console.WriteLine($"Welcome, {user.Username}!");
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }

            Close();
        }

        public User Validate(string username, string password)
        {
            return _manager.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public void Close()
        {
            Console.WriteLine("Press any key ");
            Console.ReadKey();
        }
    }
}
