// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

namespace LatianBoardGame2
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("SELAMAT BERLATIH\n\n");

            // membuat variabel cicle, saat game looping maka cicle akan bertambah
            int cicle = 1;

            // membuat instance 2 player yang nantinya akan dijadikan list, dan dilakukan looping untuk menentukan siapa yang akan menyerang
            Players gilang1 = new Players();
            gilang1.playerName = "Gilang";
            Players enemy = new Players();
            enemy.playerName = "Enemy";

            // membuat list player
            List<Players> players = new List<Players>();
            players.Add(gilang1);
            players.Add(enemy);

            // menambahkan hero ke dalam deck
            gilang1.deck.heroes.Add(new Archer("Archer1"));
            gilang1.deck.heroes.Add(new Archer("Archer2"));
            gilang1.deck.heroes.Add(new Mage());

            System.Console.WriteLine("Gilang's Deck: " );
            foreach(var result in gilang1.deck.heroes)
            {
                System.Console.WriteLine("Hero Name: " + result.heroName);
                System.Console.WriteLine(result.heroName + "'s Health: " + result.heroHealth);
                System.Console.WriteLine(result.heroName + "'s Damage: " + result.heroDamage);
            }
            System.Console.WriteLine("\n");

            // menambahkan hero ke dalam deck
            enemy.deck.heroes.Add(new Archer("Archer1(enemy)"));
            enemy.deck.heroes.Add(new Archer("Archer2(enemy)"));
            enemy.deck.heroes.Add(new Archer("Archer3(enemy)"));
            enemy.deck.heroes.Add(new Mage());

            System.Console.WriteLine("Enemy's Deck: " );
            foreach(var result in enemy.deck.heroes)
            {
                System.Console.WriteLine("Hero Name: " + result.heroName);
                System.Console.WriteLine(result.heroName + "'s Health: " + result.heroHealth);
                System.Console.WriteLine(result.heroName + "'s Damage: " + result.heroDamage);
            }

            // memulai pertarungan
            System.Console.WriteLine("\n---Game Start---\n ");
            int cicle1 = 1;
            while(gilang1.deck.heroes.Count > 0 && enemy.deck.heroes.Count > 0)
            {
                System.Console.WriteLine("\n---Game Cicle: " + cicle1 + "---");
                cicle1++;
                
                System.Console.WriteLine(gilang1.playerName + " Attack " + enemy.playerName + "'s " + enemy.deck.heroes[0].heroName );
                enemy.deck.heroes[0].heroHealth -= gilang1.deck.heroes[0].heroDamage;
                System.Console.WriteLine(enemy.playerName + "'s "+ enemy.deck.heroes[0].heroName + " Health: " + enemy.deck.heroes[0].heroHealth);

                System.Console.WriteLine(enemy.playerName + " Attack " + gilang1.playerName + "'s " + gilang1.deck.heroes[0].heroName);
                gilang1.deck.heroes[0].heroHealth -= enemy.deck.heroes[0].heroDamage;
                System.Console.WriteLine(gilang1.playerName+ "'s " + gilang1.deck.heroes[0].heroName + " Health: " + gilang1.deck.heroes[0].heroHealth);

                if(gilang1.deck.heroes[0].heroHealth <= 0)
                {
                    gilang1.deck.heroes[0].heroHealth = 0;
                    System.Console.WriteLine(gilang1.playerName + "'s"+ gilang1.deck.heroes[0].heroName + " is Dead");
                    gilang1.deck.heroes.RemoveAt(0);
                    //break;
                }

                else if(enemy.deck.heroes[0].heroHealth <= 0)
                {
                    enemy.deck.heroes[0].heroHealth = 0;
                    System.Console.WriteLine(enemy.playerName +"'s "+ enemy.deck.heroes[0].heroName +" is Dead");
                    enemy.deck.heroes.RemoveAt(0);
                    //break;
                }
            }

            if(gilang1.deck.heroes.Count > 0)
            {
                System.Console.WriteLine("\nGilang Win because hero > 0");
            }
            else if(enemy.deck.heroes.Count > 0)
            {
                System.Console.WriteLine("\nEnemy Win because hero > 0");
            }
            else
            {
                System.Console.WriteLine("\nDraw");
            }


            System.Console.WriteLine("\nGilang's final Deck: " );
            if(gilang1.deck.heroes.Count <= 0)
            {
                System.Console.WriteLine("Gilang's Hero is Dead, deck is empty");
            }
            else
            {
                foreach(var result in gilang1.deck.heroes)
                {
                    System.Console.WriteLine("Hero Name: " + result.heroName);
                    System.Console.WriteLine(result.heroName + "'s Health: " + result.heroHealth);
                    System.Console.WriteLine(result.heroName + "'s Damage: " + result.heroDamage);
                }
            }

            System.Console.WriteLine("\nEnemy's final Deck: " );
            foreach(var result in enemy.deck.heroes)
            {
                System.Console.WriteLine("Hero Name: " + result.heroName);
                System.Console.WriteLine(result.heroName + "'s Health: " + result.heroHealth);
                System.Console.WriteLine(result.heroName + "'s Damage: " + result.heroDamage);
            }
        
            
        }
    }

    public class Players
    {
        public string playerName { get; set; }
        public Deck deck = new Deck();
    }

    public class Deck
    {
        public List<IHero> heroes = new List<IHero>();
    }

    public interface IHero
    {
        public string heroName { get; set; }
        public int heroHealth { get; set; }
        public int heroDamage { get; set; }
    }

    public class Archer: IHero
    {
        public string heroName { get; set; }
        public int heroHealth { get; set; } 
        public int heroDamage { get; set; } 

        //Random random = new Random();

        public Archer(string name)
        {
            heroName = name;
            heroHealth = 100;
            //heroDamage = random.Next(1, 10);
            heroDamage = 10;
        }
    }

    public class Mage: IHero
    {
        public string heroName{ get; set; }
        public int heroHealth{ get; set; }
        public int heroDamage{ get; set; }
        //Random random = new Random();

        public Mage()
        {
            heroName = "Mage";
            heroHealth = 100;
            //heroDamage = random.Next(1, 10);
            heroDamage = 5;
        }
    }
}
