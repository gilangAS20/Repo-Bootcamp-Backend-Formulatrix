namespace MyProject_AutoChess
{

    public class Game
    {
        public List<Player> listPlayer = new List<Player>();
        public Board board = new Board();

        public string AddPlayer(string PlayerName)
        {
            Player player = new Player();
            player.GetPlayerName(PlayerName);
            listPlayer.Add(player);
            return PlayerName;
        }

        /*
        public void showListPlayer()
        {
            // tambahkan foreach untuk menampilkan isi listPlayer
            foreach (var item in listPlayer)
            {
                Console.WriteLine(item.PlayerName);
            }
        }
        */

    }
}
