using System;

namespace registerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.LoadFromFile();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("USER SYSTEM");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        RegistrationForm regForm = new RegistrationForm(manager);
                        regForm.Show();
                        break;
                    case "2":
                        LoginForm loginForm = new LoginForm(manager);
                        loginForm.Show();
                        break;
                    case "3":
                        manager.SaveToFile();
                        return;
                    default:
                        Console.WriteLine("Invalid option!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}

