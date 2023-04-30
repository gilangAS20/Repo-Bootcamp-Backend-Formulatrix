using System.Text;
using System.Diagnostics;
namespace MyProject_AutoChess
{
    public class Game
    {
        private List<Players> _listPlayers = new List<Players>();
        private Board _boardPlayerOne = new Board();
        private Board _boardPlayerTwo = new Board();
        private Stopwatch _stopWatch = new Stopwatch();

        // membuat instance player1 dan player2
        public Players _playerOne = new Players();
        public Players _playerTwo = new Players();

        // digunakan untuk method StartGame()
        private int _cicle = 1;
        public bool isPlayingMode = true;
        public int randomPlayer; // kalo diubah ke private maka tidak akan random

        public string TimerGameStart()
        {
            _stopWatch.Start();
            return "Battle timer started";
        }

        public string TimerGameStop()
        {
            _stopWatch.Stop();
            return String.Format("Battle Time: {0:0.00} seconds", _stopWatch.Elapsed.TotalSeconds);
        }
        
        public string AddPlayers(string PlayerName1, string PlayerName2)
        {
            if(_listPlayers.Count >= 2)
            {
                return "Player sudah penuh";
            }
            else
            {
                _playerOne.SetPlayerName(PlayerName1);
                _listPlayers.Add(_playerOne);

                _playerTwo.SetPlayerName(PlayerName2);
                _listPlayers.Add(_playerTwo);
            }
            return "Player 1: " + PlayerName1 + " dan Player 2: " + PlayerName2 + " telah ditambahkan";
        } // end of method AddPlayer

        public string ShowListPlayer()
        {   
            int number = 1;
            StringBuilder returnListPlayer = new StringBuilder();
            foreach (var item in _listPlayers)
            {
                returnListPlayer.Append("\nPlayer "+ number + ": " + item.GetPlayerName());
                number++;
            }
            return returnListPlayer.ToString();
        } // end of method ShowListPlayer


        public string AddHeroToDeck(Players playerInstance, string heroName, int heroLocation)
        {
            StringBuilder returnAddHero = new StringBuilder();
            if(heroLocation < 1 || heroLocation > 24)
            {
                returnAddHero.Append("Location must be between 1 and 24");
            }
            else
            {
                if(playerInstance == _playerOne)
                {
                    string returnHero = AddHeroPlayer(playerInstance, _boardPlayerOne, heroName, heroLocation);
                    returnAddHero.Append(returnHero);
                }
                else if(playerInstance == _playerTwo)
                {
                    string returnHero = AddHeroPlayer(playerInstance, _boardPlayerTwo, heroName, heroLocation);
                    returnAddHero.Append(returnHero);
                }
            }
            return returnAddHero.ToString();
        } // end of method AddHeroToDeck

        private string AddHeroPlayer(Players playerInstance, Board boardInstance, string heroName, int heroLocation)
        {
            StringBuilder returnAddHero = new StringBuilder();
            if(playerInstance.deck.listHero.Count >= 5)
            {
                returnAddHero.Append(playerInstance.GetPlayerName() + "'s deck is full");
            }
            else if(boardInstance.tiles.tile.ContainsKey(heroLocation))
            {
                returnAddHero.Append("Location " + heroLocation + " is already used by other hero");
            }
            else
            {
                if(boardInstance.CheckAvailabilityMoveTile(heroLocation) == true)
                {
                    if(heroName.ToLower() == "freya")
                    {
                        string returnHeroFreya = AddHeroFreya(playerInstance, heroLocation);
                        returnAddHero.Append(returnHeroFreya);
                        boardInstance.tiles.tile.Add(heroLocation, "freya");
                    }
                    else if(heroName.ToLower() == "garo")
                    {
                        string returnHeroGaro = AddHeroGaro(playerInstance, heroLocation);
                        returnAddHero.Append(returnHeroGaro);
                        boardInstance.tiles.tile.Add(heroLocation, "garo");
                    }
                    else if(heroName.ToLower() == "stella")
                    {   
                        string returnHeroStella = AddHeroStella(playerInstance, heroLocation);
                        returnAddHero.Append(returnHeroStella);
                        boardInstance.tiles.tile.Add(heroLocation, "stella");
                    }
                    else
                    {
                        returnAddHero.Append("Hero "+ heroName +" not found");
                    }
                }
            }

            return returnAddHero.ToString();
        } // end of method AddHeroPlayer

        private string AddHeroFreya(Players playerInstance, int heroLocation)
        {   
            StringBuilder returnAddHeroFreya = new();
            Freya freya = new Freya(heroLocation);
            returnAddHeroFreya.Append("Freya added to location " + freya.GetLocationHero());
            playerInstance.deck.listHero.Add(freya);

            return returnAddHeroFreya.ToString();
        } // end of method AddHeroFreya

        private string AddHeroGaro(Players playerInstance, int heroLocation)
        {
            StringBuilder returnAddHeroGaro = new();
            Garo garo = new Garo(heroLocation);
            returnAddHeroGaro.Append("Garo added to location " + garo.GetLocationHero());
            playerInstance.deck.listHero.Add(garo);

            return returnAddHeroGaro.ToString();
        } // end of method AddHeroGaro

        private string AddHeroStella(Players playerInstance, int heroLocation)
        {
            StringBuilder returnAddHeroStella = new();
            Stella stella = new Stella(heroLocation);
            returnAddHeroStella.Append("Stella added to location " + stella.GetLocationHero());
            playerInstance.deck.listHero.Add(stella);

            return returnAddHeroStella.ToString();
        } // end of method AddHeroStella

        public string ShowDeck(Players playerInstance)
        {
            StringBuilder returnShowDeck = new StringBuilder();
           
                returnShowDeck.Append(playerInstance.GetPlayerName() + "'s deck: \n");
                if(playerInstance.deck.listHero.Count() <= 0)
                {
                    returnShowDeck.Append("--empty--");
                }
                else
                {
                    foreach(var item in playerInstance.deck.listHero)
                    {   
                        returnShowDeck.Append(item.ShowHeroInfo());
                    }
                }

            return returnShowDeck.ToString();
        } // end of method NewShowDeck

        public int ShowTotalHP(Players playerInstance)
        {
            int totalHP = 0;
            totalHP = playerInstance.deck.listHero.Sum(x => x.GetHP());

            return totalHP;
        }

        public string RemoveHeroFromDeck(Players playerInstance, string heroName, int heroLocation = 0)
        {
            StringBuilder removeHeroFromDeck = new StringBuilder();

            if(heroLocation == 0)
            {
                removeHeroFromDeck.Append("Location must be filled");
            }
            
            else if(heroLocation < 0 || heroLocation > 24)
            {
                removeHeroFromDeck.Append("Location must be between 1 and 24");
            }

            else if(playerInstance == _playerOne)
            {
                string deleteHeroResult = RemoveHeroDeckPlayers(playerInstance, _boardPlayerOne, heroName, heroLocation);
                removeHeroFromDeck.Append(deleteHeroResult);
            }

            else if(playerInstance == _playerTwo)
            {
                string deleteHeroResult = RemoveHeroDeckPlayers(playerInstance, _boardPlayerTwo, heroName, heroLocation);
                removeHeroFromDeck.Append(deleteHeroResult);
            }

            return removeHeroFromDeck.ToString();
        }

        private string RemoveHeroDeckPlayers(Players playerInstance, Board boardInstance, string heroName, int heroLocation)
        {
            bool heroFound = false;
            StringBuilder removeHeroPlayer = new StringBuilder();

            // hapus hero di board(di tile Board.cs)
            if(boardInstance.tiles.tile.ContainsKey(heroLocation) && boardInstance.tiles.tile[heroLocation] == heroName)
            {
                removeHeroPlayer.Append($"Hero '{heroName}' with location {heroLocation} removed from deck");
                boardInstance.tiles.tile.Remove(heroLocation);

                // hapus hero di deck (di listHero Players.cs)  
                for(int i = 0; i < playerInstance.deck.listHero.Count; i++)
                {
                    if(heroName.ToLower() == playerInstance.deck.listHero[i].heroName.ToLower() && heroLocation == playerInstance.deck.listHero[i].GetLocationHero())
                    {
                        playerInstance.deck.listHero.RemoveAt(i);
                        heroFound = true;
                        break;
                    }
                }
            }

            else
            {
                removeHeroPlayer.Append($"Hero '{heroName}' with location {heroLocation} not found");
            }

            return removeHeroPlayer.ToString();
        }

        public string StartGame()
        {   
            StringBuilder startGame = new StringBuilder();

                startGame.Append("\n\t\t---Game Cicle: " + _cicle + "---\n");
                _cicle++;
                Random random = new Random();
                randomPlayer = random.Next(0,2);

                string playerTurnResult = PlayerTurn(randomPlayer);
                startGame.Append(playerTurnResult);

                if(_playerOne.deck.listHero.Count() <= 0 || _playerTwo.deck.listHero.Count() <= 0)
                {
                    isPlayingMode = false;
                }

                else if(_stopWatch.Elapsed.TotalSeconds >= 30)
                {
                    isPlayingMode = false;
                }
            return startGame.ToString();
        } // end of method StartGame


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
            playerOneTurn.AppendLine("\n--" + _playerOne.GetPlayerName() + " turn--");
            playerOneTurn.AppendLine(_playerOne.deck.listHero[0].heroName + " is attacking " + _playerTwo.deck.listHero[0].heroName);
            _playerTwo.deck.listHero[0].HP -= _playerOne.deck.listHero[0].damageHero;
            playerOneTurn.AppendLine(_playerTwo.GetPlayerName() + "'s " + _playerTwo.deck.listHero[0].heroName + " HP: " + _playerTwo.deck.listHero[0].HP);

            return playerOneTurn.ToString();
        }

        private string PlayerTwoTurn()
        {   
            StringBuilder playerTwoTurn = new StringBuilder();
            playerTwoTurn.AppendLine("\n--" + _playerTwo.GetPlayerName() + " turn--");
            playerTwoTurn.AppendLine(_playerTwo.deck.listHero[0].heroName + " is attacking " + _playerOne.deck.listHero[0].heroName);
            _playerOne.deck.listHero[0].HP -= _playerTwo.deck.listHero[0].damageHero;
            playerTwoTurn.AppendLine(_playerOne.GetPlayerName() + "'s " + _playerOne.deck.listHero[0].heroName + " HP: " + _playerOne.deck.listHero[0].HP);

            return playerTwoTurn.ToString();
        }

        public string DeleteHeroDead()
        {
            StringBuilder AlldeleteHeroDead = new StringBuilder();
            AlldeleteHeroDead.Append("");
            // jika hero mati, hapus dari listHero
            if(_playerOne.deck.listHero[0].HP <= 0)
            {
                AlldeleteHeroDead.AppendLine(_playerOne.GetPlayerName() + "'s " + _playerOne.deck.listHero[0].heroName + " is dead");
                _playerOne.deck.listHero.RemoveAt(0);
            }

            if(_playerTwo.deck.listHero[0].HP <= 0)
            {
                AlldeleteHeroDead.AppendLine(_playerTwo.GetPlayerName() + "'s " + _playerTwo.deck.listHero[0].heroName + " is dead");
                _playerTwo.deck.listHero.RemoveAt(0);
            }
            else
            {
                AlldeleteHeroDead.Append("");
            }

            return AlldeleteHeroDead.ToString();
        } // end of method DeleteHeroDead

        public string IsLoseOrWin()
        {   
            StringBuilder isLoseOrWin = new StringBuilder();

            if(_playerOne.deck.listHero.Count() > 0 && ShowTotalHP(_playerOne) > ShowTotalHP(_playerTwo))
            {
                isLoseOrWin.AppendLine("\n===" + _playerOne.GetPlayerName() + " win! " + _playerTwo.GetPlayerName() + " lose!===");
            }
            else if(_playerTwo.deck.listHero.Count() > 0 && ShowTotalHP(_playerTwo) > ShowTotalHP(_playerOne))
            {
                isLoseOrWin.AppendLine("\n===" + _playerTwo.GetPlayerName() + " win! " + _playerOne.GetPlayerName() + " lose!===");
            }
            else
            {
                isLoseOrWin.AppendLine("\nDraw!");
            }

            isLoseOrWin.AppendLine(_playerOne.GetPlayerName() + "'s Total HP: " + ShowTotalHP(_playerOne));
            isLoseOrWin.AppendLine(_playerTwo.GetPlayerName() + "'s Total HP: " + ShowTotalHP(_playerTwo));

            return isLoseOrWin.ToString();
        } // end of method IsLoseOrWin

    } // end of class Game
} // end of namespace MyProject_AutoChess