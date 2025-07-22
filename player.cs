using System;
using System.Collections.Generic;

public class Player
{
    public string Name { get; set; }
    public string Alias { get; set; }
    public int Wins { get; private set; }
    public int Losses { get; private set; }

    public Player(string name, string alias)
    {
        Name = name;
        Alias = alias;
        Wins = 0;
        Losses = 0;
    }
    public void WinGame()
    {
        Wins++;
    }
    public void LoseGame()
    {
        Losses++;
    }
    public override string ToString()
    {
        return $"{Alias} ({Name})-Wins:{Wins},Losses:{Losses}";
    }
}



