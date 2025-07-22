class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager();

        string input;
        do
        {
            manager.CreateNewGame();

            Console.Write("\n Play again?: ");
            input = Console.ReadLine().ToLower();

        } while (input == "yes");

        
    }
}
