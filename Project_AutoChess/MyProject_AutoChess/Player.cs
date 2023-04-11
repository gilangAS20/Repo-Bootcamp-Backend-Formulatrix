namespace MyProject_AutoChess
{

    public class Player
    {
        public string PlayerName {get;set;}
        Deck deck = new Deck();

        public string GetPlayerName(string PlayerName)
        {
            this.PlayerName = PlayerName;
            return PlayerName;
        }
    }
}
