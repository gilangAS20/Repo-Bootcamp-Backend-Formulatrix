// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MyProject_AutoChess;

class Program
{
    static void Main()
    {
        Game game = new Game();
        game.AddPlayer("Player 1");
        game.AddPlayer("Player 2");
        //game.showListPlayer();

        foreach (var item in game.listPlayer)
        {
            System.Console.WriteLine("halo");
            Console.WriteLine(item.PlayerName);
        }
    }
}

