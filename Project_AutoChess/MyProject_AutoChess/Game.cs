using System.Text;
using System.Diagnostics;
namespace MyProject_AutoChess
{
    public class Game
    {
        private List<Players> listPlayer = new List<Players>();
        private Board boardPlayerOne = new Board();
        private Board boardPlayerTwo = new Board();
        private Stopwatch stopwatch = new Stopwatch();

        // membuat instance player1 dan player2
        private Players playerOne = new Players();
        private Players playerTwo = new Players();

        public string TimerGameStart()
        {
            stopwatch.Start();
            return "Battle timer started";
        }

        public string TimerGameStop()
        {
            stopwatch.Stop();
            return String.Format("Battle Time: {0:0.00} seconds", stopwatch.Elapsed.TotalSeconds);
        }
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
        {   int number = 1;
            StringBuilder returnListPlayer = new StringBuilder();
            foreach (var item in listPlayer)
            {
                returnListPlayer.Append("\nPlayer "+ number + ": " + item.GetPlayerName());
                number++;
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

        private string AddHeroPlayerOne(string heroName, int location)
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

        private string AddHeroPlayerTwo(string heroName, int location)
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

        private string ShowDeckPlayerOne()
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

        private string ShowDeckPlayerTwo()
        {   
            StringBuilder showDeckPlayerTwo = new StringBuilder();
            showDeckPlayerTwo.Append( playerTwo.GetPlayerName() + "'s deck: \n");
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

        private string RemoveHeroPlayerOne(string playerName, string heroName)
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

        private string RemoveHeroPlayerTwo(string playerName, string heroName)
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


        private int cicle = 1;
        public bool isPlayingMode = true;
        public int randomPlayer; // kalo diubah ke private maka tidak akan random
        public string StartGame()
        {   
            StringBuilder startGame = new StringBuilder();

                startGame.Append("\n\t\t---Game Cicle: " + cicle + "---\n");
                cicle++;
                Random random = new Random();
                randomPlayer = random.Next(0,2);

                string test = PlayerTurn(randomPlayer);
                if(test.Contains("is dead"))
                {
                    startGame.Append(test);
                }
                else
                {
                    startGame.Append(test);
                }

                if(playerOne.deck.listHero.Count() <= 0 || playerTwo.deck.listHero.Count() <= 0)
                {
                    isPlayingMode = false;
                }
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

        public string PlayerTurn(int randomPlayer)
        {
            StringBuilder playerTurn = new StringBuilder();

            playerTurn.Append("==========================================================");
            if(randomPlayer == 0)
            {
                // player1 turn
                string playerOneTurn = PlayerOneTurn();
                playerTurn.Append(playerOneTurn);

                // player2 turn
                string playerTwoTurn = PlayerTwoTurn();
                playerTurn.Append(playerTwoTurn);
            }
            else
            {
                // player2 turn
                string playerOneTurn = PlayerTwoTurn();
                playerTurn.Append(playerOneTurn);

                // player1 turn
                string playerTwoTurn = PlayerOneTurn();
                playerTurn.Append(playerTwoTurn); 
            }
            string deleteHeroDead = DeleteHeroDead();
            playerTurn.Append(deleteHeroDead);

            playerTurn.Append("=========================--===============================");
            return playerTurn.ToString();
        }

        private string PlayerOneTurn()
        {  
            StringBuilder playerOneTurn = new StringBuilder();
            playerOneTurn.AppendLine("\n--" + playerOne.GetPlayerName() + " turn--");
            playerOneTurn.AppendLine(playerOne.deck.listHero[0].heroName + " is attacking " + playerTwo.deck.listHero[0].heroName);
            playerTwo.deck.listHero[0].HP -= playerOne.deck.listHero[0].damageHero;
            playerOneTurn.AppendLine(playerTwo.GetPlayerName() + "'s " + playerTwo.deck.listHero[0].heroName + " HP: " + playerTwo.deck.listHero[0].HP);

            return playerOneTurn.ToString();
        }

        private string PlayerTwoTurn()
        {   
            StringBuilder playerTwoTurn = new StringBuilder();
            playerTwoTurn.AppendLine("\n--" + playerTwo.GetPlayerName() + " turn--");
            playerTwoTurn.AppendLine(playerTwo.deck.listHero[0].heroName + " is attacking " + playerOne.deck.listHero[0].heroName);
            playerOne.deck.listHero[0].HP -= playerTwo.deck.listHero[0].damageHero;
            playerTwoTurn.AppendLine(playerOne.GetPlayerName() + "'s " + playerOne.deck.listHero[0].heroName + " HP: " + playerOne.deck.listHero[0].HP);

            return playerTwoTurn.ToString();
        }

        public string DeleteHeroDead()
        {
            StringBuilder AlldeleteHeroDead = new StringBuilder();
            AlldeleteHeroDead.Append("");
            // jika hero mati, hapus dari listHero
            if(playerOne.deck.listHero[0].HP <= 0)
            {
                AlldeleteHeroDead.AppendLine(playerOne.GetPlayerName() + "'s " + playerOne.deck.listHero[0].heroName + " is dead");
                playerOne.deck.listHero.RemoveAt(0);
            }

            if(playerTwo.deck.listHero[0].HP <= 0)
            {
                AlldeleteHeroDead.AppendLine(playerTwo.GetPlayerName() + "'s " + playerTwo.deck.listHero[0].heroName + " is dead");
                playerTwo.deck.listHero.RemoveAt(0);
            }
            else
            {
                AlldeleteHeroDead.Append("");
            }

            return AlldeleteHeroDead.ToString();
        } // end of method DeleteHeroDead
    } // end of class Game
} // end of namespace MyProject_AutoChess