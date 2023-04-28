// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace CobaFolder
{
    public class Player
    {
        private string playerName;

        public void SetGetPlayerName(string name)
        {
            this.playerName = name;
            System.Console.WriteLine("Player Name: " + playerName);
        }
    }
    
}