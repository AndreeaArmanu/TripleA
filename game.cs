using System;
using System.Collections.Generic;
public class Game
    {
        private string wordToGuess;
        private string hiddenWord;
        private int tries;
        private int remainingTries;
        private List<char> guessedLetters;
        private Player player;

    public void Init(string word, Player p)
    {
        wordToGuess = word.ToUpper();
        hiddenWord = new string('_', word.Length);
        tries = 6;
        remainingTries = tries;
        guessedLetters = new List<char>();
        player = p;
    }
    public void Start()
    {
        Console.WriteLine($"\n{player.Alias} starts guessing");

        while (remainingTries > 0 && hiddenWord.Contains("_"))
        {
            Console.WriteLine($"\nWord: {hiddenWord}");
            Console.WriteLine($"tries left: {remainingTries}");
            Console.Write("guess a letter: ");
            char guess = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (guessedLetters.Contains(guess))
            {
                Console.WriteLine("Already guessed");
                continue;
            }

            guessedLetters.Add(guess);

            if (wordToGuess.Contains(guess))
            {
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess)
                    {
                        hiddenWord = hiddenWord.Remove(i, 1).Insert(i, guess.ToString());
                    }
                }
                Console.WriteLine("Correct");
            }
            else
            {
                remainingTries--;
                Console.WriteLine("Wrong");
            }
        }

        End();
    }

    public void End()
    {
        if (!hiddenWord.Contains("_"))
        {
            Console.WriteLine($"\n {player.Alias} guessed the word: {wordToGuess}");
            player.WinGame();
        }
        else
        {
            Console.WriteLine($"\n The word was: {wordToGuess}");
            player.LoseGame();
        }
    }
}



