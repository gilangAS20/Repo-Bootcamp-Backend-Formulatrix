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
        private Players _playerOne = new Players();
        private Players _playerTwo = new Players();

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
        {   int number = 1;
            StringBuilder returnListPlayer = new StringBuilder();
            foreach (var item in _listPlayers)
            {
                returnListPlayer.Append("\nPlayer "+ number + ": " + item.GetPlayerName());
                number++;
            }
            return returnListPlayer.ToString();
        } // end of method ShowListPlayer

        //public string AddHeroToDeck(string playerName, string heroName, int location)
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
                if(playerName == _playerOne.GetPlayerName())
                {
                    string returnHero = AddHeroPlayerOne(heroName, location);
                    returnAddHero.Append(returnHero);
                }

                // menambahkan hero ke dalam deck player2
                else if(playerName == _playerTwo.GetPlayerName())
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
            if(_boardPlayerOne.CheckAvailabilityMoveTile(location) == true)
            {
                if(heroName.ToLower() == "freya")
                {
                    Freya freya = new Freya(location);
                    returnAddHero.Append("Freya added to location " + freya.GetLocationHero());
                    _playerOne.deck.listHero.Add(freya);
                    _boardPlayerOne.tiles.tile.Add(location, "freya");
                }
                else if(heroName.ToLower() == "garo")
                {
                    Garo garo = new Garo(location);
                    returnAddHero.Append("Garo added to location " + garo.GetLocationHero());
                    _playerOne.deck.listHero.Add(garo);
                    _boardPlayerOne.tiles.tile.Add(location, "garo");
                }
                else if(heroName.ToLower() == "stella")
                {   
                    Stella stella = new Stella(location);
                    returnAddHero.Append("Stella added to location " + stella.GetLocationHero());
                    _playerOne.deck.listHero.Add(stella);
                    _boardPlayerOne.tiles.tile.Add(location, "stella");
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
            if(_boardPlayerTwo.CheckAvailabilityMoveTile(location) == true)
            {
                if(heroName.ToLower() == "freya")
                {
                    Freya freya = new Freya(location);
                    returnAddHero.Append("Freya added to location " + freya.GetLocationHero());
                    _playerTwo.deck.listHero.Add(freya);
                    _boardPlayerTwo.tiles.tile.Add(location, "freya");
                }
                else if(heroName.ToLower() == "garo")
                {
                    Garo garo = new Garo(location);
                    returnAddHero.Append("Garo added to location " + garo.GetLocationHero());
                    _playerTwo.deck.listHero.Add(garo);
                    _boardPlayerTwo.tiles.tile.Add(location, "garo");
                }
                else if(heroName.ToLower() == "stella")
                {   
                    Stella stella = new Stella(location);
                    returnAddHero.Append("Stella added to location " + stella.GetLocationHero());
                    _playerTwo.deck.listHero.Add(stella);
                    _boardPlayerTwo.tiles.tile.Add(location, "stella");
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
            if(_playerOne.GetPlayerName() == playerName)
            {
                string deckPlayerOne = ShowDeckPlayerOne();
                showDeck.Append(deckPlayerOne);
            }

            else if(_playerTwo.GetPlayerName() == playerName)
            {
                string deckPlayerTwo = ShowDeckPlayerTwo();
                showDeck.Append(deckPlayerTwo);
            }

            return showDeck.ToString();
        } // end of method ShowDeck

        private string ShowDeckPlayerOne()
        {
            StringBuilder showDeckPlayerOne = new StringBuilder();
            showDeckPlayerOne.Append(_playerOne.GetPlayerName() + "'s deck: \n");
            if(_playerOne.deck.listHero.Count() <= 0)
            {
                showDeckPlayerOne.Append("--empty--");
            }
            else
            {
                foreach(var item in _playerOne.deck.listHero)
                {   
                    showDeckPlayerOne.Append(item.ShowHeroInfo());
                }
            }

            return showDeckPlayerOne.ToString();
        } // end of method ShowDeckPlayerOne

        private string ShowDeckPlayerTwo()
        {   
            StringBuilder showDeckPlayerTwo = new StringBuilder();
            showDeckPlayerTwo.Append( _playerTwo.GetPlayerName() + "'s deck: \n");
            if(_playerTwo.deck.listHero.Count() <= 0)
            {
                showDeckPlayerTwo.Append("--empty--");
            }
            else
            {
                foreach(var item in _playerTwo.deck.listHero)
                {
                    showDeckPlayerTwo.Append(item.ShowHeroInfo());
                }
            }

            return showDeckPlayerTwo.ToString();
        } // end of method ShowDeckPlayerTwo

        public string RemoveHeroFromDeck(string playerName, string heroName)
        {
            StringBuilder removeHeroFromDeck = new StringBuilder();
            if(_playerOne.GetPlayerName() == playerName)
            {
                string removeHeroPlayerOne = RemoveHeroPlayerOne(playerName, heroName);
                removeHeroFromDeck.Append(removeHeroPlayerOne);
            }

            else if(_playerTwo.GetPlayerName() == playerName)
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
            for(int i = 0; i < _playerOne.deck.listHero.Count; i++)
            {
                if(heroName.ToLower() == _playerOne.deck.listHero[i].heroName.ToLower())
                {
                    removeHeroPlayerOne.Append($"Hero '{heroName}' removed from deck");
                    _playerOne.deck.listHero.RemoveAt(i);
                    heroFound = true;
                    break;
                }
            }

            // menghapus isi dari boardPlayerOne.tiles.tile sesuai dengan heroName
            foreach(var item in _boardPlayerOne.tiles.tile)
            {
                if(heroName.ToLower() == item.Value)
                {
                    _boardPlayerOne.tiles.tile.Remove(item.Key);
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
            for(int i = 0; i < _playerTwo.deck.listHero.Count; i++)
            {
                if(heroName.ToLower() == _playerTwo.deck.listHero[i].heroName.ToLower())
                {   
                    removeHeroPlayerTwo.Append($"Hero '{heroName}' removed from deck");
                    _playerTwo.deck.listHero.RemoveAt(i);
                    heroFound = true;
                    break;
                }
            }
            // menghapus isi dari boardPlayerOne.tiles.tile sesuai dengan heroName
            foreach(var item in _boardPlayerTwo.tiles.tile)
            {
                if(heroName.ToLower() == item.Value)
                {
                    _boardPlayerTwo.tiles.tile.Remove(item.Key);
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

                startGame.Append("\n\t\t---Game Cicle: " + _cicle + "---\n");
                _cicle++;
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

                if(_playerOne.deck.listHero.Count() <= 0 || _playerTwo.deck.listHero.Count() <= 0)
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

            if(_playerOne.deck.listHero.Count() > 0)
            {
                isLoseOrWin.Append("\n===" + _playerOne.GetPlayerName() + " win! " + _playerTwo.GetPlayerName() + " lose!===");
            }
            else if(_playerTwo.deck.listHero.Count() > 0)
            {
                isLoseOrWin.Append("\n===" + _playerTwo.GetPlayerName() + " win! " + _playerOne.GetPlayerName() + " lose!===");
            }
            else
            {
                isLoseOrWin.Append("\nDraw!");
            }

            return isLoseOrWin.ToString();
        } // end of method IsLoseOrWin
    } // end of class Game
} // end of namespace MyProject_AutoChess