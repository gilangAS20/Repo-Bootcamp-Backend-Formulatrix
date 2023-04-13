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
        System.Console.WriteLine("=== SELAMAT DATANG DI AUTOCHESS ===\n");


        // membuat instance untuk class Game
        Game game = new Game();
        

        // menambahkan player
        game.AddPlayer("Gilang", "Enemy");
        game.AddPlayer("yuki", "Enemiii"); // ini untuk tes aja, berhasil untuk tidak masuk ke listPlayer

        // menampilkan jumlah isi dari game.listPlayer
        System.Console.WriteLine("Jumlah player dalam listPlayer: ");
        System.Console.WriteLine(game.listPlayer.Count);
        
        // menampilkan isi dari game.listPlayer
        System.Console.WriteLine("Isi dari listPlayer: ");
        game.ShowListPlayer();

        System.Console.WriteLine("\n");
        // menambahkan hero ke dalam deck
        game.AddHeroToDeck("Gilang", "assassin");
        // menampilkan deck Gilang
        System.Console.WriteLine("Deck Gilang: ");
        game.ShowDeck("Gilang");

    }
}

