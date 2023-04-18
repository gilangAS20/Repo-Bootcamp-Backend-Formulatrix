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

        // ==================================Make Game Instance===========================================
        // membuat instance untuk class Game
        Game game = new Game();
        // menambahkan player
        Console.WriteLine(game.AddPlayers("Gilang", "Enemy"));
        Console.WriteLine(game.AddPlayers("yuki", "Enemiii")); // ini untuk tes aja, berhasil untuk tidak masuk ke listPlayer

        // menampilkan jumlah isi dari game.listPlayer
        System.Console.WriteLine("\nJumlah player dalam listPlayer: ");
        System.Console.WriteLine(game.listPlayer.Count);
        
        // menampilkan isi dari game.listPlayer
        System.Console.WriteLine("\nIsi dari listPlayer: ");
        game.ShowListPlayer();
        System.Console.WriteLine("\n");
        // ========================================================================================


        // ==================================player1===============================================
        // menambahkan hero player1 ke dalam deck
        System.Console.WriteLine("\n--add hero to Gilang's deck--");
        game.AddHeroToDeck("Gilang", "freya", 1);
        game.AddHeroToDeck("Gilang", "garo", 2);
        game.AddHeroToDeck("Gilang", "stella", 2);
        game.AddHeroToDeck("Gilang", "slebew", 4);

        // menampilkan deck Gilang (player1)
        System.Console.WriteLine("\n--show Gilang's deck--");
        game.ShowDeck("Gilang");
        System.Console.WriteLine("\n");

        // tes delete hero player1 dari dalam deck
        System.Console.WriteLine("\nDelete hero from Gilang's deck: ");
        game.RemoveHeroFromDeck("Gilang", "freya");
        game.RemoveHeroFromDeck("Gilang", "anjay");
        System.Console.WriteLine("\nDeck Gilang(after remove): ");
        game.ShowDeck("Gilang");

        // menambahkan kembali hero player1 ke dalam deck
        System.Console.WriteLine("Add hero to gilang's deck ");
        game.AddHeroToDeck("Gilang", "freya", 1);
        game.ShowDeck("Gilang");
        // ========================================================================================


        // ==================================player2===============================================
        // menambahkan hero player2 ke dalam deck
        System.Console.WriteLine("\n--add hero to Enemy's deck--");
        game.AddHeroToDeck("Enemy", "garo", 1);
        game.AddHeroToDeck("Enemy", "stella", 3);
        game.AddHeroToDeck("Enemy", "freya", 3);
        game.AddHeroToDeck("Enemy", "plankton", 4);

        // menampilkan deck Enemy
        System.Console.WriteLine("\n--show Enemy's deck--");
        game.ShowDeck("Enemy");
        System.Console.WriteLine("\n");
        
        // tes delete hero player2 dari dalam deck
        System.Console.WriteLine("\nDelete hero from Enemy's deck: ");
        game.RemoveHeroFromDeck("Enemy", "garo");
        game.RemoveHeroFromDeck("Enemy", "yuzu");
        System.Console.WriteLine("\nDeck Enemy(after remove): ");
        game.ShowDeck("Enemy");

        // menambahkan kembali hero player2 ke dalam deck
        System.Console.WriteLine("Add hero to enemy's deck ");
        game.AddHeroToDeck("Enemy", "garo", 1);
        game.ShowDeck("Enemy");
        // ========================================================================================

        System.Console.WriteLine("\n");


        
        System.Console.WriteLine("\n");


        // ======================Game Dimulai============================================
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

