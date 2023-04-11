// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

namespace Latian_BoardGame_TurnBased
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // membuat variabel cicle, saat game looping maka cicle akan bertambah
            int cicle = 1;

            //make instance player
            Player gilang = new Player();
            gilang.name = "Gilang";

            //make instance for enemy
            Random random = new Random();
            Enemy myEnemy = new Enemy(random);

            // game play
            Console.WriteLine("Game Start\n ");
            Console.WriteLine(gilang.DisplayPlayerInfo());
            Console.WriteLine(myEnemy.DisplayEnemyInfo());
            System.Console.WriteLine("\n are you ready? \n");
            Console.ReadKey();
            Thread.Sleep(1000);

            while(gilang.health > 0 && myEnemy.health > 0)
            {   System.Console.WriteLine("---Game Cicle: " + cicle + "---");
                cicle++;

                Console.WriteLine("\nGilang Attack");
                myEnemy.health -= gilang.damage;
                Console.WriteLine(myEnemy.ShowEnemyHealthDamage());
                Thread.Sleep(2000);

                Console.WriteLine("\n\nEnemy Attack");
                gilang.health -= myEnemy.damage;
                Console.WriteLine(gilang.ShowPlayerHealthDamage());
                Thread.Sleep(2000);

                System.Console.WriteLine("Enter to continue\n\n");
                Console.ReadKey();
                Thread.Sleep(2000);

                if(gilang.health <= 0)
                {   
                    gilang.health = 0;
                    Console.WriteLine("\n--Enemy Win, Gilang Lose--\n");
                    break;
                }
                else if (myEnemy.health <= 0)
                {
                    myEnemy.health = 0;
                    Console.WriteLine("\n--Gilang Win, Enemy Lose--\n");
                    break;
                }
            }
        }
    }

    public class Player
    {
        public string name { get; set; }
        public int health = 100;
        public int damage = 10;

        public string DisplayPlayerInfo()
        {
            return $"Player Name: {name} \nHealth: {health} \nDamage: {damage}";
        }

        public string ShowPlayerHealthDamage()
        {
            return $"{name} Health: {health} \n{name} Damage: {damage}";
        }
    }

    public class Enemy
    {
        public Random random;
        public string name = "MyEnemy";
        public int health;
        public int damage;

        public Enemy(Random random)
        {
            this.random = random;
            health = 100;
            damage = random.Next(1, 20);
            if(damage == 10)
            {
                random.Next(1, 20);
            }
        }

        public string DisplayEnemyInfo()
        {
            return $"Enemy Name: {name} \nHealth: {health} \nDamage: {damage}";
        }

        public string ShowEnemyHealthDamage()
        {
            return $"{name} Health: {health} \n{name} Damage: {damage}";
        }
    }
}
