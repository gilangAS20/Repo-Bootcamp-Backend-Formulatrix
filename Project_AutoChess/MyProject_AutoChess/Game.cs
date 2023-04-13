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
        
        // membuat instance player1 dan player2
        Players player1 = new Players();
        Players player2 = new Players();
        public string AddPlayer(string PlayerName1, string PlayerName2)
        {
            if(listPlayer.Count >= 2)
            {
                return "Player sudah penuh";
            }
            else
            {
                player1.PlayerName = PlayerName1;
                listPlayer.Add(player1);

                player2.PlayerName = PlayerName2;
                listPlayer.Add(player2);
            }
            return "Player 1: " + PlayerName1 + " dan Player 2: " + PlayerName2 + " telah ditambahkan";
        }

        public void ShowListPlayer()
        {
            foreach (var item in listPlayer)
            {
                Console.WriteLine("Player: " + item.PlayerName);
            }
        }

        public void AddHeroToDeck(string playerName, string heroName)
        {
            if(playerName == player1.PlayerName)
            {
                if(heroName.ToLower() == "freya")
                {
                    player1.deck.listHero.Add(freya);
                }
            }
            else if(playerName == player2.PlayerName)
            {
                if(heroName.ToLower() == "freya")
                {
                    player2.deck.listHero.Add(freya);
                }
            }
        }

        public void ShowDeck(string playerName)
        {
            if(playerName == player1.PlayerName)
            {
                foreach (var item in player1.deck.listHero)
                {
                    Console.WriteLine("Hero: " + item.heroName);
                }
            }
            else if(playerName == player2.PlayerName)
            {
                foreach (var item in player2.deck.listHero)
                {
                    Console.WriteLine("Hero: " + item.heroName);
                }
            }
        }
    }
}
