using registerApp;
using System;
using System.Linq;

namespace registerApp
{
    public class RegistrationForm
    {
        private Manager _manager;

        public RegistrationForm(Manager manager)
        {
            _manager = manager;
        }

        public void Show()
        {
            Console.Clear();
            Console.WriteLine(" Registration ");

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            if (Validate(username, password, email))
            {
                User newUser = new User
                {
                    ID = _manager.GenerateNewId(),
                    Username = username,
                    Password = password,
                    Email = email
                };
                _manager.Users.Add(newUser);
                Console.WriteLine("Registration successful!");
            }
            else
            {
                Console.WriteLine("Registration failed.");
            }

            Close();
        }

        public bool Validate(string username, string password, string email)
        {
            if (_manager.Users.Any(u => u.Username == username))
            {
                Console.WriteLine("Username already exists.");
                return false;
            }

            if (password.Length < 5)
            {
                Console.WriteLine("Password too short.");
                return false;
            }

            if (!email.Contains("@"))
            {
                Console.WriteLine("Invalid email.");
                return false;
            }

            return true;
        }

        public void Close()
        {
            Console.WriteLine("Press any key ");
            Console.ReadKey();
        }
    }
}
