namespace MyProject_AutoChess
{
    public class Board
    {
        List<Tile> listTiles = new List<Tile>();

        public bool CheckAvailabilityMoveTile(List<Tile> listTiles)
        {
            // jika tile yang dipilih belum ada hero, maka return true
            // jika tile yang dipilih sudah ada hero, maka return false
            return true;
        }
    }

    public class Tile
    {
        List<int> tile = new List<int>();
    }
}