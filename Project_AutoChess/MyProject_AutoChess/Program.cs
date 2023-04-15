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
        System.Console.WriteLine("=== SELAMAT DATANG DI AUTOCHESS ===");


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
        System.Console.WriteLine("\n");

        // menambahkan hero player1 ke dalam deck
        game.AddHeroToDeck("Gilang", "freya");
        game.AddHeroToDeck("Gilang", "garo");
        game.AddHeroToDeck("Gilang", "stella");

        // menambahkan hero player2 ke dalam deck
        game.AddHeroToDeck("Enemy", "garo");
        game.AddHeroToDeck("Enemy", "stella");
        game.AddHeroToDeck("Enemy", "freya");

        // menampilkan deck Gilang
        game.ShowDeck("Gilang");
        System.Console.WriteLine("\n");

        // menampilkan deck Enemy
        game.ShowDeck("Enemy");
        System.Console.WriteLine("\n");

        // tes delete hero player1 dari dalam deck
        System.Console.WriteLine("\nDelete hero from Gilang's deck: ");
        game.RemoveHeroFromDeck("Gilang", "freya");
        game.RemoveHeroFromDeck("Gilang", "anjay");
        System.Console.WriteLine("\nDeck Gilang(after remove): ");
        game.ShowDeck("Gilang");


        // tes delete hero player2 dari dalam deck
        System.Console.WriteLine("\nDelete hero from Enemy's deck: ");
        //game.RemoveHeroFromDeck("Enemy", "garo");
        game.RemoveHeroFromDeck("Enemy", "yuzu");
        System.Console.WriteLine("\nDeck Enemy(after remove): ");
        game.ShowDeck("Enemy");
        Console.WriteLine("=========================================================");

        // memulai pertarungan
        game.StartGame();

        // melihat siapa yang menang
        game.IsLoseOrWin();

        // menampilkan deck akhir setelah pertarungan
        System.Console.WriteLine("\nDeck Gilang(after game): ");
        game.ShowDeck("Gilang");
        System.Console.WriteLine("\nDeck Enemy(after game): ");
        game.ShowDeck("Enemy");
    }
}

