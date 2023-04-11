// See https://aka.ms/new-console-template for more information
// boardgame battleship
// 1. create a board
// 2. create a ship
// 3. place the ship on the board
// 4. create a player
// 5. create a game
// 6. play the game

using System;
using System.Collections.Generic;

namespace ProjectBoardGame
{
    class Program
    {
        static void Main()
        {





        }
    }

    public interface IShip
    {
        public string shipName { get; set; }
        public int shipSize { get; set; }
        //make coordinates of ship
        public List<Coordinate> shipCoordinates { get; set; }
        //make a list of coordinates that have been hit
        public List<Coordinate> hitCoordinates { get; set; }

    }

    public class BattleShip : IShip
    {
        public string shipName { get; set; }
        public int shipSize { get; set; }
        public List<Coordinate> shipCoordinates { get; set; }
        public List<Coordinate> hitCoordinates { get; set; }

        public BattleShip()
        {
            shipName = "Battleship";
            shipSize = 4;
            shipCoordinates = new List<Coordinate>();
            hitCoordinates = new List<Coordinate>();
        }
    }

    public class Carrier : IShip
    {
        public string shipName { get; set; }
        public int shipSize { get; set; }
        public List<Coordinate> shipCoordinates { get; set; }
        public List<Coordinate> hitCoordinates { get; set; }

        public Carrier()
        {
            shipName = "Carrier";
            shipSize = 5;
            shipCoordinates = new List<Coordinate>();
            hitCoordinates = new List<Coordinate>();
        }
    }

    public class Cruiser : IShip
    {
        public string shipName { get; set; }
        public int shipSize { get; set; }
        public List<Coordinate> shipCoordinates { get; set; }
        public List<Coordinate> hitCoordinates { get; set; }

        public Cruiser()
        {
            shipName = "Cruiser";
            shipSize = 3;
            shipCoordinates = new List<Coordinate>();
            hitCoordinates = new List<Coordinate>();
        }
    }

    public class Submarine : IShip
    {
        public string shipName { get; set; }
        public int shipSize { get; set; }
        public List<Coordinate> shipCoordinates { get; set; }
        public List<Coordinate> hitCoordinates { get; set; }

        public Submarine()
        {
            shipName = "Submarine";
            shipSize = 3;
            shipCoordinates = new List<Coordinate>();
            hitCoordinates = new List<Coordinate>();
        }
    }

    public class Destroyer : IShip
    {
        public string shipName { get; set; }
        public int shipSize { get; set; }
        public List<Coordinate> shipCoordinates { get; set; }
        public List<Coordinate> hitCoordinates { get; set; }

        public Destroyer()
        {
            shipName = "Destroyer";
            shipSize = 2;
            shipCoordinates = new List<Coordinate>();
            hitCoordinates = new List<Coordinate>();
        }
    }

    public class Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Board
    {
        public int boardSize { get; set; }
        public List<Coordinate> boardCoordinates { get; set; }

        public Board(int boardSize)
        {
            this.boardSize = boardSize;
            boardCoordinates = new List<Coordinate>();
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    boardCoordinates.Add(new Coordinate(i, j));
                }
            }
        }
    }

    public class Player
    {
        public string playerName { get; set; }
        public List<IShip> playerShips { get; set; }
        public Board playerBoard = new Board(10);

        public Player(string playerName)
        {
            this.playerName = playerName;
            playerShips = new List<IShip>();
        }
    }

    public class Game
    {
        public Player player1 { get; set; }
        public Player player2 { get; set; }

        public Game(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
    }

    public class GamePlay
    {
        public Game game { get; set; }

        public GamePlay(Game game)
        {
            this.game = game;
        }

        public void PlayGame()
        {
            
        }
    }


}
