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

        // menambahkan player
        Console.WriteLine(game.AddPlayers("Gilang", "Enemy"));
        //Console.WriteLine(game.AddPlayers("yuki", "Enemiii")); // ini untuk tes aja, berhasil untuk tidak masuk ke listPlayer

        // menampilkan isi dari game.listPlayer
        System.Console.WriteLine("\nIsi dari listPlayer: ");
        System.Console.WriteLine(game.ShowListPlayer());
        System.Console.Write("\n");
        // ====================================================================================


        // ==================================player1===========================================
        System.Console.WriteLine("==================================================");

        // menambahkan hero player1 ke dalam deck
        System.Console.WriteLine("--add hero to Gilang's deck--");
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "freya", 24));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "garo", 2));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "stella", 22));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "stella", 19));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "garo", 12)); // hilangkan command code jika mau cek winner dengan totalHP tertinggi
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "stella", 2)); // fail karena lokasi sudah digunakan
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "stella", 30)); // fail karena lokasi harus antara 1-24
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "slebew", 4)); // fail karena hero tidak ada

        // menampilkan deck Gilang (player1)
        System.Console.WriteLine("\n--show Gilang's deck--");
        System.Console.WriteLine(game.ShowDeck(game._playerOne));

        // tes delete hero player1 dari dalam deck
        System.Console.WriteLine("\nDelete hero from Gilang's deck: ");
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerOne, "garo", 25));
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerOne, "garo")); // location cannot be empty
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerOne, "garo", 12));
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerOne, "stella", 19));
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerOne, "freya", 2));
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerOne, "Shiro"));

        // menampilkan deck Gilang (player1) setelah remove
        System.Console.WriteLine("\nDeck Gilang(after remove): ");
        System.Console.WriteLine(game.ShowDeck(game._playerOne));

        // menambahkan kembali hero player1 ke dalam deck
        System.Console.WriteLine("\n--add hero to Gilang's deck--");
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "freya", 1));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "stella", 2));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "stella", 19));

        // menampilkan deck Gilang (player1)
        System.Console.WriteLine("\n--show Gilang's deck--");
        System.Console.WriteLine(game.ShowDeck(game._playerOne));

        System.Console.WriteLine("==================================================");
        // ====================================================================================

    
        // ==================================player2===========================================
        System.Console.WriteLine("\n==================================================");

        // menambahkan hero player2 ke dalam deck
        System.Console.WriteLine("--add hero to Enemy's deck--");
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "garo", 1));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "garo", 2));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "stella", 3));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "stella", 17));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "plankton", 4)); // fail karena nama hero tidak ada
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "freya", 21));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "freya", 24));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "freya", 3)); // fail karena lokasi sudah digunakan
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "freya", 0)); // fail karena lokasi harus antara 1 dan 24

        // menampilkan deck Enemy (player2)
        System.Console.WriteLine("\n--show Enemy's deck--");
        System.Console.WriteLine(game.ShowDeck(game._playerTwo));

        // tes delete hero player2 dari dalam deck
        System.Console.WriteLine("\nDelete hero from Enemy's deck: ");
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerTwo, "garo", 1));
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerTwo, "garo", 12));
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerTwo, "stella", 25));
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerTwo, "suhu", 17));

        // menampilkan deck Enemy (player2) setelah remove
        System.Console.WriteLine("\nDeck Enemy(after remove): ");
        System.Console.WriteLine(game.ShowDeck(game._playerTwo));

        // menambahkan kembali hero player2 ke dalam deck
        System.Console.WriteLine("\n--add hero to Enemy's deck--");
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "garo", 1));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "freya", 6));

        // menampilkan deck Enemy (player2)
        System.Console.WriteLine("\n--show Enemy's deck--");
        System.Console.WriteLine(game.ShowDeck(game._playerTwo));

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

        // melihat siapa yang menang
        System.Console.WriteLine(game.IsLoseOrWin());

        // menampilkan deck akhir setelah pertarungan
        System.Console.WriteLine("\nGilang's Deck (after game): ");
        System.Console.WriteLine(game.ShowDeck(game._playerOne));

        System.Console.WriteLine("\nEnemy's Deck (after game): ");
        System.Console.WriteLine(game.ShowDeck(game._playerTwo));
        // ====================================================================================
    }
}

