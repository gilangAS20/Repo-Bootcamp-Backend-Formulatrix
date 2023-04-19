namespace MyProject_AutoChess
{
    public class Players
    {
        private string? playerName {get;set;}
        public Deck deck = new Deck();

        public string SetPlayerName(string name)
        {
            playerName = name;
            return playerName;
        }

        public string GetPlayerName()
        {
            return playerName;
        }
    }


}
