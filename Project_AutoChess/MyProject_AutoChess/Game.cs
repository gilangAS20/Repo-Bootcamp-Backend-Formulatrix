using System.Text;
namespace MyProject_AutoChess
{

    public class Game
    {
        public List<Players> listPlayer = new List<Players>();
        public Board boardPlayerOne = new Board();
        public Board boardPlayerTwo = new Board();
        //public Deck deck = new Deck();

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
                playerOne.SetPlayerName(PlayerName1);
                listPlayer.Add(playerOne);

                playerTwo.SetPlayerName(PlayerName2);
                listPlayer.Add(playerTwo);
            }
            return "Player 1: " + PlayerName1 + " dan Player 2: " + PlayerName2 + " telah ditambahkan";
        } // end of method AddPlayer

        public string ShowListPlayer()
        {
            StringBuilder returnListPlayer = new StringBuilder();
            foreach (var item in listPlayer)
            {
                returnListPlayer.Append("\nPlayer: " + item.GetPlayerName());
            }
            return returnListPlayer.ToString();
        } // end of method ShowListPlayer

        public string AddHeroToDeck(string playerName, string heroName, int location)
        {
            StringBuilder returnAddHero = new StringBuilder();
            if(location < 1 || location > 24)
            {
                returnAddHero.Append("Location must be between 1 and 24");
            }
            else
            {
                // menambahkan hero ke dalam deck player1
                if(playerName == playerOne.GetPlayerName())
                {
                    string returnHero = AddHeroPlayerOne(heroName, location);
                    returnAddHero.Append(returnHero);

                }

                // menambahkan hero ke dalam deck player2
                else if(playerName == playerTwo.GetPlayerName())
                {
                    string returnHero = AddHeroPlayerTwo(heroName, location);
                    returnAddHero.Append(returnHero);
                }
            }
            return returnAddHero.ToString();
        } // end of method AddHeroToDeck

        public string AddHeroPlayerOne(string heroName, int location)
        {
            StringBuilder returnAddHero = new StringBuilder();
            if(boardPlayerOne.CheckAvailabilityMoveTile(location) == true)
            {
                if(heroName.ToLower() == "freya")
                {
                    Freya freya = new Freya(location);
                    returnAddHero.Append("Freya added to location " + freya.GetLocationHero());
                    playerOne.deck.listHero.Add(freya);
                    boardPlayerOne.tiles.tile.Add(location, "freya");
                }
                else if(heroName.ToLower() == "garo")
                {
                    Garo garo = new Garo(location);
                    returnAddHero.Append("Garo added to location " + garo.GetLocationHero());
                    playerOne.deck.listHero.Add(garo);
                    boardPlayerOne.tiles.tile.Add(location, "garo");
                }
                else if(heroName.ToLower() == "stella")
                {   
                    Stella stella = new Stella(location);
                    returnAddHero.Append("Stella added to location " + stella.GetLocationHero());
                    playerOne.deck.listHero.Add(stella);
                    boardPlayerOne.tiles.tile.Add(location, "stella");
                }
                else
                {
                    returnAddHero.Append("Hero "+ heroName +" not found");
                }
            }
            else
            {
                returnAddHero.Append("Tile " + location + " is not available");
            }

            return returnAddHero.ToString();
        } // end of method AddHeroPlayerOne

        public string AddHeroPlayerTwo(string heroName, int location)
        {   StringBuilder returnAddHero = new StringBuilder();
            if(boardPlayerTwo.CheckAvailabilityMoveTile(location) == true)
            {
                if(heroName.ToLower() == "freya")
                {
                    Freya freya = new Freya(location);
                    returnAddHero.Append("Freya added to location " + freya.GetLocationHero());
                    playerTwo.deck.listHero.Add(freya);
                    boardPlayerTwo.tiles.tile.Add(location, "freya");
                }
                else if(heroName.ToLower() == "garo")
                {
                    Garo garo = new Garo(location);
                    returnAddHero.Append("Garo added to location " + garo.GetLocationHero());
                    playerTwo.deck.listHero.Add(garo);
                    boardPlayerTwo.tiles.tile.Add(location, "garo");
                }
                else if(heroName.ToLower() == "stella")
                {   
                    Stella stella = new Stella(location);
                    returnAddHero.Append("Stella added to location " + stella.GetLocationHero());
                    playerTwo.deck.listHero.Add(stella);
                    boardPlayerTwo.tiles.tile.Add(location, "stella");
                }
                else
                {
                    returnAddHero.Append("Hero "+ heroName +" not found");
                }
            }
            else
            {
                returnAddHero.Append("Tile " + location + " is not available");
            }

            return returnAddHero.ToString();
        } // end of method AddHeroPlayerTwo

        public string ShowDeck(string playerName)
        {
            StringBuilder showDeck = new StringBuilder();
            if(playerOne.GetPlayerName() == playerName)
            {
                string deckPlayerOne = ShowDeckPlayerOne();
                showDeck.Append(deckPlayerOne);
            }
            
            else if(playerTwo.GetPlayerName() == playerName)
            {
                string deckPlayerTwo = ShowDeckPlayerTwo();
                showDeck.Append(deckPlayerTwo);
            }

            return showDeck.ToString();
        } // end of method ShowDeck

        public string ShowDeckPlayerOne()
        {
            StringBuilder showDeckPlayerOne = new StringBuilder();
            showDeckPlayerOne.Append(playerOne.GetPlayerName() + "'s deck: \n");
            if(playerOne.deck.listHero.Count() <= 0)
            {
                showDeckPlayerOne.Append("--empty--");
            }
            else
            {
                foreach(var item in playerOne.deck.listHero)
                {   
                    showDeckPlayerOne.Append(item.ShowHeroInfo());
                }
            }

            return showDeckPlayerOne.ToString();
        } // end of method ShowDeckPlayerOne

        public string ShowDeckPlayerTwo()
        {   
            StringBuilder showDeckPlayerTwo = new StringBuilder();
            showDeckPlayerTwo.Append( playerTwo.GetPlayerName() + "'s deck: ");
            if(playerTwo.deck.listHero.Count() <= 0)
            {
                showDeckPlayerTwo.Append("--empty--");
            }
            else
            {
                foreach(var item in playerTwo.deck.listHero)
                {
                    showDeckPlayerTwo.Append(item.ShowHeroInfo());
                }
            }

            return showDeckPlayerTwo.ToString();
        } // end of method ShowDeckPlayerTwo

        public string RemoveHeroFromDeck(string playerName, string heroName)
        {
            StringBuilder removeHeroFromDeck = new StringBuilder();
            if(playerOne.GetPlayerName() == playerName)
            {
                string removeHeroPlayerOne = RemoveHeroPlayerOne(playerName, heroName);
                removeHeroFromDeck.Append(removeHeroPlayerOne);
            }

            else if(playerTwo.GetPlayerName() == playerName)
            {
                string removeHeroPlayerTwo = RemoveHeroPlayerTwo(playerName, heroName);
                removeHeroFromDeck.Append(removeHeroPlayerTwo);
            }

            return removeHeroFromDeck.ToString();
        } // end of method RemoveHeroFromDeck
        
        public string RemoveHeroPlayerOne(string playerName, string heroName)
        {   
            bool heroFound = false;
            StringBuilder removeHeroPlayerOne = new StringBuilder();
            // jika heroName sesuai dengan heroName yang ada di dalam listHero, hapus melalui index
            for(int i = 0; i < playerOne.deck.listHero.Count; i++)
            {
                if(heroName.ToLower() == playerOne.deck.listHero[i].heroName.ToLower())
                {
                    removeHeroPlayerOne.Append($"Hero '{heroName}' removed from deck");
                    playerOne.deck.listHero.RemoveAt(i);
                    heroFound = true;
                    break;
                }
            }

            // menghapus isi dari boardPlayerOne.tiles.tile sesuai dengan heroName
            foreach(var item in boardPlayerOne.tiles.tile)
            {
                if(heroName.ToLower() == item.Value)
                {
                    boardPlayerOne.tiles.tile.Remove(item.Key);
                    break;
                }
            }
            if(!heroFound)
            {
                removeHeroPlayerOne.Append($"Hero '{heroName}' not found");
            }

            return removeHeroPlayerOne.ToString();
        } // end of method RemoveHeroPlayerOne

        public string RemoveHeroPlayerTwo(string playerName, string heroName)
        {
            bool heroFound = false;
            StringBuilder removeHeroPlayerTwo = new StringBuilder();
            // jika heroName sesuai dengan heroName yang ada di dalam listHero, hapus melalui index
            for(int i = 0; i < playerTwo.deck.listHero.Count; i++)
            {
                if(heroName.ToLower() == playerTwo.deck.listHero[i].heroName.ToLower())
                {   
                    removeHeroPlayerTwo.Append($"Hero '{heroName}' removed from deck");
                    playerTwo.deck.listHero.RemoveAt(i);
                    heroFound = true;
                    break;
                }
            }
            // menghapus isi dari boardPlayerOne.tiles.tile sesuai dengan heroName
            foreach(var item in boardPlayerTwo.tiles.tile)
            {
                if(heroName.ToLower() == item.Value)
                {
                    boardPlayerTwo.tiles.tile.Remove(item.Key);
                    break;
                }
            }
            if(!heroFound)
            {
                removeHeroPlayerTwo.Append($"Hero '{heroName}' not found");
            }

            return removeHeroPlayerTwo.ToString();
        } // end of method RemoveHeroPlayerTwo

        public string StartGame()
        {
            StringBuilder startGame = new StringBuilder();
            Console.ReadKey();
            int cicle = 1;
            int randomPlayer;

            while(playerOne.deck.listHero.Count() > 0 && playerTwo.deck.listHero.Count() > 0)
            {
                System.Console.WriteLine("\n\t\t---Game Cicle: " + cicle + "---");
                cicle++;
                Random random = new Random();
                randomPlayer = random.Next(0,2);
                //System.Console.WriteLine("Random player: " + randomPlayer);

                // memanggil method PlayerTurn(randomPlayer) untuk pergantian menyerang
                PlayerTurn(randomPlayer);
            } // end of while

            return startGame.ToString();
        } // end of method StartGame

        public string IsLoseOrWin()
        {   
            StringBuilder isLoseOrWin = new StringBuilder();

            if(playerOne.deck.listHero.Count() > 0)
            {
                isLoseOrWin.Append("\n===" + playerOne.GetPlayerName() + " win! " + playerTwo.GetPlayerName() + " lose!===");
            }
            else if(playerTwo.deck.listHero.Count() > 0)
            {
                isLoseOrWin.Append("\n===" + playerTwo.GetPlayerName() + " win! " + playerOne.GetPlayerName() + " lose!===");
            }
            else
            {
                isLoseOrWin.Append("\nDraw!");
            }

            return isLoseOrWin.ToString();
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
                System.Console.WriteLine("\n--" + playerOne.GetPlayerName() + " turn--");
                System.Console.WriteLine(playerOne.deck.listHero[0].heroName + " is attacking " + playerTwo.deck.listHero[0].heroName);
                playerTwo.deck.listHero[0].HP -= playerOne.deck.listHero[0].damageHero;
                System.Console.WriteLine(playerTwo.GetPlayerName() + "'s " + playerTwo.deck.listHero[0].heroName + " HP: " + playerTwo.deck.listHero[0].HP);
        }

        public void PlayerTwoTurn()
        {
            // playerTwo attack to playerOne
                System.Console.WriteLine("\n--" + playerTwo.GetPlayerName() + " turn--");
                System.Console.WriteLine(playerTwo.deck.listHero[0].heroName + " is attacking " + playerOne.deck.listHero[0].heroName);
                playerOne.deck.listHero[0].HP -= playerTwo.deck.listHero[0].damageHero;
                System.Console.WriteLine(playerOne.GetPlayerName() + "'s " + playerOne.deck.listHero[0].heroName + " HP: " + playerOne.deck.listHero[0].HP);
        }

        public void DeleteHeroDead()
        {
            // jika hero mati, hapus dari listHero
            if(playerOne.deck.listHero[0].HP <= 0)
            {
                playerOne.deck.listHero[0].HP = 0;
                System.Console.WriteLine(playerOne.GetPlayerName() + "'s " + playerOne.deck.listHero[0].heroName + " is dead");
                playerOne.deck.listHero.RemoveAt(0);
                System.Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
            }

            if(playerTwo.deck.listHero[0].HP <= 0)
            {
                playerTwo.deck.listHero[0].HP = 0;
                System.Console.WriteLine(playerTwo.GetPlayerName() + "'s " + playerTwo.deck.listHero[0].heroName + " is dead");
                playerTwo.deck.listHero.RemoveAt(0);
                System.Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
            }
        }
    } // end of class Game
} // end of namespace MyProject_AutoChess