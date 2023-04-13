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
        System.Console.WriteLine("\nJumlah player dalam listPlayer: ");
        System.Console.WriteLine(game.listPlayer.Count);
        
        // menampilkan isi dari game.listPlayer
        System.Console.WriteLine("\nIsi dari listPlayer: ");
        game.ShowListPlayer();

        // menambahkan hero ke dalam deck
        game.AddHeroToDeck("Gilang", "freya");
        // menampilkan deck Gilang
        System.Console.WriteLine("\nDeck Gilang: ");
        game.ShowDeck("Gilang");

        // menambahkan hero ke dalam deck
        game.AddHeroToDeck("Enemy", "freya");
        // menampilkan deck Enemy
        System.Console.WriteLine("\nDeck Enemy: ");
        game.ShowDeck("Enemy");

    }
}

