namespace MyProject_AutoChess
{

    public class Game
    {
        public List<Players> listPlayer = new List<Players>();
        public Board board = new Board();
        public Deck deck = new Deck();
        //public Assassin assassin = new Assassin();

        // membuat instance hero
        public Freya freya = new Freya();
        public Garo garo = new Garo();
        public Stella stella = new Stella();
        
        // membuat instance player1 dan player2
        Players playerOne = new Players();
        Players playerTwo = new Players();
        public string AddPlayer(string PlayerName1, string PlayerName2)
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
            if(playerName == playerOne.playerName)
            {
                if(heroName.ToLower() == "freya")
                {
                    playerOne.deck.listHero.Add(freya);
                }
                else if(heroName.ToLower() == "garo")
                {
                    playerOne.deck.listHero.Add(garo);
                }
                else if(heroName.ToLower() == "stella")
                {
                    playerOne.deck.listHero.Add(stella);
                }
            }

            else if(playerName == playerTwo.playerName)
            {
                if(heroName.ToLower() == "freya")
                {
                    playerTwo.deck.listHero.Add(freya);
                }
                else if(heroName.ToLower() == "garo")
                {
                    playerTwo.deck.listHero.Add(garo);
                }
                else if(heroName.ToLower() == "stella")
                {
                    playerTwo.deck.listHero.Add(stella);
                }
            }
        } // end of method AddHeroToDeck

        public void ShowDeck(string playerName)
        {
            if(playerOne.playerName == playerName)
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
            }
            
            else if(playerTwo.playerName == playerName)
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
            }
        } // end of method ShowDeck

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

        public void StartGame()
        {
            System.Console.WriteLine("\n---Game Start---\n ");
            System.Console.WriteLine("--Press any key to play---\n ");
            Console.ReadKey();
            int cicle = 1;
            while(playerOne.deck.listHero.Count() > 0 && playerTwo.deck.listHero.Count() > 0)
            {
                System.Console.WriteLine("\n---Game Cicle: " + cicle + "---");
                cicle++;

                // memanggil method PlayerTurn() untuk pergantian menyerang
                PlayerTurn();

                // menghapus hero yang mati dari listHero milik player
                DeleteHeroDead();
                
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

        public void PlayerTurn()
        {
            // player1 turn
            System.Console.WriteLine("--" + playerOne.playerName + " turn--");
            playerTwo.deck.listHero[0].HP -= playerOne.deck.listHero[0].damageHero;
            System.Console.WriteLine(playerOne.deck.listHero[0].heroName + " is attacking " + playerTwo.deck.listHero[0].heroName);
            System.Console.WriteLine(playerTwo.playerName + "'s " + playerTwo.deck.listHero[0].heroName + " HP: " + playerTwo.deck.listHero[0].HP);

            // player2 turn
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

        public void RemoveHeroPlayerOne(string playerName, string heroName)
        {   
            bool heroFound = false;
            if(playerName == playerOne.playerName)
            {
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
            }
            if(!heroFound)
            {
                System.Console.WriteLine($"Hero '{heroName}' not found");
            }
        }

        public void RemoveHeroPlayerTwo(string playerName, string heroName)
        {
            bool heroFound = false;
            if(playerName == playerTwo.playerName)
            {   
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
            }
            if(!heroFound)
            {
                System.Console.WriteLine($"Hero '{heroName}' not found");
            }
        }
    } // end of class Game
} // end of namespace MyProject_AutoChess
