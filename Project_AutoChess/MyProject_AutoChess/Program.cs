// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace MyProject_AutoChess;

static class Program
{
    static async Task Main()
    {
        System.Console.WriteLine("=== SELAMAT DATANG DI AUTOCHESS ===");

        // ==================================Make Game Instance================================
        // membuat instance untuk class Game
        Game game = new Game();

        // menambahkan player --> return value console sudah diganti string
        Console.WriteLine(game.AddPlayers("Gilang", "Enemy"));
        Console.WriteLine(game.AddPlayers("yuki", "Enemiii")); // ini untuk tes aja, berhasil untuk tidak masuk ke listPlayer

        // menampilkan isi dari game.listPlayer --> return value console sudah diganti string
        System.Console.WriteLine("\nIsi dari listPlayer: ");
        System.Console.WriteLine(game.ShowListPlayer());
        System.Console.Write("\n");
        // ====================================================================================


        // ==================================player1===========================================
        System.Console.WriteLine("==================================================");

        // menambahkan hero player1 ke dalam deck --> return value console sudah diganti string
        System.Console.WriteLine("--add hero to Gilang's deck--");
        System.Console.WriteLine(game.AddHeroToDeck("Gilang", "freya", 24));
        System.Console.WriteLine(game.AddHeroToDeck("Gilang", "garo", 2));
        //System.Console.WriteLine(game.AddHeroToDeck("Gilang", "garo", 12)); // hilangkan command code jika mau cek winner dengan totalHP tertinggi
        System.Console.WriteLine(game.AddHeroToDeck("Gilang", "stella", 2)); // fail karena lokasi sudah digunakan
        System.Console.WriteLine(game.AddHeroToDeck("Gilang", "stella", 30)); // fail karena lokasi harus antara 1-24
        System.Console.WriteLine(game.AddHeroToDeck("Gilang", "slebew", 4)); // fail karena hero tidak ada

        // menampilkan deck Gilang (player1)
        System.Console.WriteLine("\n--show Gilang's deck--");
        System.Console.WriteLine(game.ShowDeck("Gilang")); // return value console sudah diganti string

        // tes delete hero player1 dari dalam deck --> return value console sudah diganti string
        System.Console.WriteLine("\nDelete hero from Gilang's deck: ");
        //System.Console.WriteLine(game.RemoveHeroFromDeck("Gilang", "freya"));
        System.Console.WriteLine(game.RemoveHeroFromDeck(heroName: "freya", playerName: "Gilang"));
        System.Console.WriteLine(game.RemoveHeroFromDeck("Gilang", "anjay"));

        System.Console.WriteLine("\nDeck Gilang(after remove): ");
        System.Console.WriteLine(game.ShowDeck("Gilang")); // return value console sudah diganti string

        // menambahkan kembali hero player1 ke dalam deck --> return value console sudah diganti string
        System.Console.WriteLine("\n--add hero to Gilang's deck--");
        System.Console.WriteLine(game.AddHeroToDeck("Gilang", "freya", 1));
        System.Console.WriteLine(game.AddHeroToDeck("Gilang", "stella", 7));

        // menampilkan deck Gilang (player1)
        System.Console.WriteLine("\n--show Gilang's deck--");
        System.Console.WriteLine(game.ShowDeck("Gilang")); // return value console sudah diganti string
        System.Console.WriteLine("==================================================");
        // ====================================================================================

    
        // ==================================player2===========================================
        System.Console.WriteLine("\n==================================================");

        // menambahkan hero player2 ke dalam deck --> return value console sudah diganti string
        System.Console.WriteLine("--add hero to Enemy's deck--");
        System.Console.WriteLine(game.AddHeroToDeck("Enemy", "garo", 1));
        System.Console.WriteLine(game.AddHeroToDeck("Enemy", "stella", 3));
        System.Console.WriteLine(game.AddHeroToDeck("Enemy", "freya", 3)); // fail karena lokasi sudah digunakan
        System.Console.WriteLine(game.AddHeroToDeck("Enemy", "freya", 0)); // fail karena lokasi harus antara 1 dan 24
        System.Console.WriteLine(game.AddHeroToDeck("Enemy", "plankton", 4)); // fail karena nama hero tidak ada

        // menampilkan deck Enemy (player2)
        System.Console.WriteLine("\n--show Enemy's deck--");
        System.Console.WriteLine(game.ShowDeck("Enemy")); // return value console sudah diganti string

        // tes delete hero player2 dari dalam deck --> return value console sudah diganti string
        System.Console.WriteLine("\nDelete hero from Enemy's deck: ");
        System.Console.WriteLine(game.RemoveHeroFromDeck("Enemy", "garo"));
        System.Console.WriteLine(game.RemoveHeroFromDeck("Enemy", "yuzu"));

        System.Console.WriteLine("\nDeck Enemy(after remove): ");
        System.Console.WriteLine(game.ShowDeck("Enemy")); // return value console sudah diganti string

        // menambahkan kembali hero player2 ke dalam deck --> return value console sudah diganti string
        System.Console.WriteLine("\n--add hero to Enemy's deck--");
        System.Console.WriteLine(game.AddHeroToDeck("Enemy", "garo", 1));
        System.Console.WriteLine(game.AddHeroToDeck("Enemy", "freya", 6));

        // menampilkan deck Enemy (player2)
        System.Console.WriteLine("\n--show Enemy's deck--");
        System.Console.WriteLine(game.ShowDeck("Enemy")); // return value console sudah diganti string
        System.Console.WriteLine("==================================================");
        // ====================================================================================


        // =====================================Game Dimulai===================================
        System.Console.WriteLine("==================================================");

        // memulai pertarungan
        System.Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("\n    ---Game Start---\n ");
        System.Console.WriteLine("--Press any key to play---\n ");
        System.Console.ResetColor();
        Console.ReadKey();

        // looping untuk menampilkan proses serang
        System.Console.WriteLine(game.TimerGameStart());
        while(game.isPlayingMode == true)
        {
            string startMyGame = game.StartGame();
            System.Console.WriteLine(startMyGame);
            //Thread.Sleep(500);
            await Task.Delay(500); // dia mempengaruhi nilai dari timer
            if(startMyGame.Contains("is dead"))
            {   
                System.Console.WriteLine("---Press any key to continue---\n ");
                Console.ReadKey();
            }
        }
        System.Console.WriteLine("\n ===Game Over===\n");
        System.Console.WriteLine(game.TimerGameStop());

        // melihat siapa yang menang --> return value console sudah diganti string
        System.Console.WriteLine(game.IsLoseOrWin());

        // menampilkan deck akhir setelah pertarungan
        System.Console.WriteLine("\nGilang's Deck (after game): ");
        System.Console.WriteLine(game.ShowDeck("Gilang")); // return value console sudah diganti string
        System.Console.WriteLine("\nEnemy's Deck (after game): ");
        System.Console.WriteLine(game.ShowDeck("Enemy")); // return value console sudah diganti string
        // ====================================================================================
    }
}

