// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace MyProject_AutoChess;

public partial class Program
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

        // set Board Size (optional, default is 24)
        game.SetBoardSize(25);
        System.Console.WriteLine("Board Size: "  + game.GetBoardSize());
        
        // ====================================================================================


        // ==================================player1===========================================
        InitializePlayerOne(game);
        // ====================================================================================

        
        // ==================================player2===========================================
        InitializePlayerTwo(game);
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

