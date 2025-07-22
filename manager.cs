using System;

public class Manager
{
    public void CreateNewGame()
    {
        Console.Write("name: ");
        string name = Console.ReadLine();

        Console.Write("your alias: ");
        string alias = Console.ReadLine();

        Player player = new Player(name, alias);

        Console.Write("Enter a word to guess: ");
        string word = Console.ReadLine();
        Console.Clear();

        Game game = new Game();
        game.Init(word, player);
        game.Start();
    }
}
