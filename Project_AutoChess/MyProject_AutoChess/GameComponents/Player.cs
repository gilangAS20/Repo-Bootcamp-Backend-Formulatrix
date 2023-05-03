namespace MyProject_AutoChess
{
    public class Players
    {
        private string? _playerName; //{get;set;}
        public Deck deck = new Deck();

        public string SetPlayerName(string name)
        {
            _playerName = name;
            return _playerName;
        }

        public string GetPlayerName()
        {
            return _playerName;
        }
    }


}
