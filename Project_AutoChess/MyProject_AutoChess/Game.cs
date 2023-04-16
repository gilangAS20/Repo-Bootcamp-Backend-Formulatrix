namespace MyProject_AutoChess
{

    public class Game
    {
        public List<Players> listPlayer = new List<Players>();
        public Board board = new Board();
        public Deck deck = new Deck();

        // membuat instance hero
        //public Freya freya = new Freya();
        //public Garo garo = new Garo();
        //public Stella stella = new Stella();
        
        // membuat instance player1 dan player2
        Players playerOne = new Players();
        Players playerTwo = new Players();
        public string AddPlayers(string PlayerName1, string PlayerName2)
        {
            if(listPlayer.Count >= 2)
            {
                return "Player sudah penuh";
            }
            else
            {
                playerOne.playerName = PlayerName1;
                listPlayer.Add(playerOne);

                playerTwo.playerName = PlayerName2;
                listPlayer.Add(playerTwo);
            }
            return "Player 1: " + PlayerName1 + " dan Player 2: " + PlayerName2 + " telah ditambahkan";
        } // end of method AddPlayer

        public void ShowListPlayer()
        {
            foreach (var item in listPlayer)
            {
                Console.WriteLine("Player: " + item.playerName);
            }
        } // end of method ShowListPlayer

        public void AddHeroToDeck(string playerName, string heroName)
        {
            // menambahkan hero ke dalam deck player1
            if(playerName == playerOne.playerName)
            {
                AddHeroPlayerOne(heroName);
            }

            // menambahkan hero ke dalam deck player2
            else if(playerName == playerTwo.playerName)
            {
                AddHeroPlayerTwo(heroName);
            }
        } // end of method AddHeroToDeck

        public void AddHeroPlayerOne(string heroName)
        {
            if(heroName.ToLower() == "freya")
            {
                Freya freya = new Freya();
                playerOne.deck.listHero.Add(freya);
            }
            else if(heroName.ToLower() == "garo")
            {
                Garo garo = new Garo();
                playerOne.deck.listHero.Add(garo);
            }
            else if(heroName.ToLower() == "stella")
            {   
                Stella stella = new Stella();
                playerOne.deck.listHero.Add(stella);
            }
            else
            {
                System.Console.WriteLine("Hero "+ heroName +" not found");
            }
        } // end of method AddHeroPlayerOne

        public void AddHeroPlayerTwo(string heroName)
        {
            if(heroName.ToLower() == "freya")
            {
                Freya freya = new Freya();
                playerTwo.deck.listHero.Add(freya);
            }
            else if(heroName.ToLower() == "garo")
            {
                Garo garo = new Garo();
                playerTwo.deck.listHero.Add(garo);
            }
            else if(heroName.ToLower() == "stella")
            {
                Stella stella = new Stella();
                playerTwo.deck.listHero.Add(stella);
            }
            else
            {
                System.Console.WriteLine("Hero "+ heroName +" not found");
            }
        } // end of method AddHeroPlayerTwo

        public void ShowDeck(string playerName)
        {
            if(playerOne.playerName == playerName)
            {
                ShowDeckPlayerOne();
            }
            
            else if(playerTwo.playerName == playerName)
            {
                ShowDeckPlayerTwo();
            }
        } // end of method ShowDeck

        public void ShowDeckPlayerOne()
        {
            System.Console.WriteLine( playerOne.playerName + "'s deck: ");
            if(playerOne.deck.listHero.Count() <= 0)
            {
                System.Console.WriteLine("--empty--");
            }
            else
            {
                foreach(var item in playerOne.deck.listHero)
                {
                    System.Console.WriteLine("Hero name: " + item.heroName);
                    System.Console.WriteLine("HP: " + item.HP);
                }
            }
        } // end of method ShowDeckPlayerOne

        public void ShowDeckPlayerTwo()
        {
            System.Console.WriteLine( playerTwo.playerName + "'s deck: ");
            if(playerTwo.deck.listHero.Count() <= 0)
            {
                System.Console.WriteLine("--empty--");
            }
            else
            {
                foreach(var item in playerTwo.deck.listHero)
                {
                    System.Console.WriteLine("Hero name: " + item.heroName);
                    System.Console.WriteLine("HP: " + item.HP);
                }
            }
        } // end of method ShowDeckPlayerTwo

        public void RemoveHeroFromDeck(string playerName, string heroName)
        {
            if(playerOne.playerName == playerName)
            {
                RemoveHeroPlayerOne(playerName, heroName);
            }

            else if(playerTwo.playerName == playerName)
            {
                RemoveHeroPlayerTwo(playerName, heroName);
            }
        } // end of method RemoveHeroFromDeck
        
        public void RemoveHeroPlayerOne(string playerName, string heroName)
        {   
            bool heroFound = false;
            // jika heroName sesuai dengan heroName yang ada di dalam listHero, hapus melalui index
            for(int i = 0; i < playerOne.deck.listHero.Count; i++)
            {
                if(heroName.ToLower() == playerOne.deck.listHero[i].heroName.ToLower())
                {
                    System.Console.WriteLine($"Hero '{heroName}' removed from deck");
                    playerOne.deck.listHero.RemoveAt(i);
                    heroFound = true;
                    break;
                }
            }
            if(!heroFound)
            {
                System.Console.WriteLine($"Hero '{heroName}' not found");
            }
        } // end of method RemoveHeroPlayerOne

        public void RemoveHeroPlayerTwo(string playerName, string heroName)
        {
            bool heroFound = false;
  
            // jika heroName sesuai dengan heroName yang ada di dalam listHero, hapus melalui index
            for(int i = 0; i < playerTwo.deck.listHero.Count; i++)
            {
                if(heroName.ToLower() == playerTwo.deck.listHero[i].heroName.ToLower())
                {   
                    System.Console.WriteLine($"Hero '{heroName}' removed from deck");
                    playerTwo.deck.listHero.RemoveAt(i);
                    heroFound = true;
                    break;
                }
            }
            if(!heroFound)
            {
                System.Console.WriteLine($"Hero '{heroName}' not found");
            }
        } // end of method RemoveHeroPlayerTwo

        public void StartGame()
        {
            System.Console.WriteLine("\n---Game Start---\n ");
            System.Console.WriteLine("--Press any key to play---\n ");
            Console.ReadKey();
            int cicle = 1;
            int randomPlayer;

            while(playerOne.deck.listHero.Count() > 0 && playerTwo.deck.listHero.Count() > 0)
            {
                System.Console.WriteLine("\n---Game Cicle: " + cicle + "---");
                cicle++;
                Random random = new Random();
                randomPlayer = random.Next(0,2);
                //System.Console.WriteLine("Random player: " + randomPlayer);
                
                // memanggil method PlayerTurn(randomPlayer) untuk pergantian menyerang
                PlayerTurn(randomPlayer);
            } // end of while
        } // end of method StartGame

        public void IsLoseOrWin()
        {
            if(playerOne.deck.listHero.Count() > 0)
            {
                System.Console.WriteLine("\n===" + playerOne.playerName + " win! " + playerTwo.playerName + " lose!===");
            }
            else if(playerTwo.deck.listHero.Count() > 0)
            {
                System.Console.WriteLine("\n===" + playerTwo.playerName + " win! " + playerOne.playerName + " lose!===");
            }
            else
            {
                System.Console.WriteLine("\nDraw!");
            }
        } // end of method IsLoseOrWin

        public void PlayerTurn(int randomPlayer)
        {
            System.Console.WriteLine("==========================================================");
            //DeleteHeroDead();
            if(randomPlayer == 0)
            {
                // player1 turn
                PlayerOneTurn();

                // player2 turn
                PlayerTwoTurn();

                //DeleteHeroDead();
            }
            else
            {
                // player2 turn
                PlayerTwoTurn();

                // player1 turn
                PlayerOneTurn();

                //DeleteHeroDead();
            }
            DeleteHeroDead();
            System.Console.WriteLine("==========================================================");
            Thread.Sleep(500);
        }

        public void PlayerOneTurn()
        {
            // playerOne attack to playerTwo
                System.Console.WriteLine("--" + playerOne.playerName + " turn--");
                playerTwo.deck.listHero[0].HP -= playerOne.deck.listHero[0].damageHero;
                System.Console.WriteLine(playerOne.deck.listHero[0].heroName + " is attacking " + playerTwo.deck.listHero[0].heroName);
                System.Console.WriteLine(playerTwo.playerName + "'s " + playerTwo.deck.listHero[0].heroName + " HP: " + playerTwo.deck.listHero[0].HP);
        }

        public void PlayerTwoTurn()
        {
            // playerTwo attack to playerOne
                System.Console.WriteLine("--" + playerTwo.playerName + " turn--");
                playerOne.deck.listHero[0].HP -= playerTwo.deck.listHero[0].damageHero;
                System.Console.WriteLine(playerTwo.deck.listHero[0].heroName + " is attacking " + playerOne.deck.listHero[0].heroName);
                System.Console.WriteLine(playerOne.playerName + "'s " + playerOne.deck.listHero[0].heroName + " HP: " + playerOne.deck.listHero[0].HP);
        }

        public void DeleteHeroDead()
        {
            // jika hero mati, hapus dari listHero
            if(playerOne.deck.listHero[0].HP <= 0)
            {
                playerOne.deck.listHero[0].HP = 0;
                System.Console.WriteLine(playerOne.playerName + "'s " + playerOne.deck.listHero[0].heroName + " is dead");
                playerOne.deck.listHero.RemoveAt(0);
            }

            if(playerTwo.deck.listHero[0].HP <= 0)
            {
                playerTwo.deck.listHero[0].HP = 0;
                System.Console.WriteLine(playerTwo.playerName + "'s " + playerTwo.deck.listHero[0].heroName + " is dead");
                playerTwo.deck.listHero.RemoveAt(0);
            }
        }
    } // end of class Game
} // end of namespace MyProject_AutoChess
