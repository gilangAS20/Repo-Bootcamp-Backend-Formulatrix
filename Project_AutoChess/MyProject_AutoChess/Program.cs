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
        game.AddHeroToDeck("Gilang", "garo");
        game.AddHeroToDeck("Gilang", "stella");
        // menampilkan deck Gilang
        System.Console.WriteLine("\nDeck Gilang: ");
        game.ShowDeck("Gilang");

        // tes delete hero dari dalam deck
        System.Console.WriteLine("Delete hero from Gilang's deck: ");
        game.RemoveHeroFromDeck("Gilang", "garo");
        game.RemoveHeroFromDeck("Gilang", "anjay");
        System.Console.WriteLine("\nDeck Gilang(after remove): ");
        game.ShowDeck("Gilang");

        // menambahkan hero ke dalam deck
        game.AddHeroToDeck("Enemy", "garo");
        game.AddHeroToDeck("Enemy", "freya");
        game.AddHeroToDeck("Enemy", "stella");
        // menampilkan deck Enemy
        System.Console.WriteLine("\nDeck Enemy: ");
        game.ShowDeck("Enemy");

        // tes delete hero dari dalam deck
        System.Console.WriteLine("Delete hero from Enemy's deck: ");
        game.RemoveHeroFromDeck("Enemy", "stella");
        game.RemoveHeroFromDeck("Enemy", "garo");
        game.RemoveHeroFromDeck("Enemy", "yuzu");
        System.Console.WriteLine("\nDeck Enemy(after remove): ");
        game.ShowDeck("Enemy");

    }
}

