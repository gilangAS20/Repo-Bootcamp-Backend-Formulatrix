namespace MyProject_AutoChess
{
    public class Board
    {
        // properties
        public Tile tiles = new Tile();
        public bool CheckAvailabilityMoveTile(int tile)
        {
            // jika tile yang dipilih belum ada hero, maka return true
            // jika tile yang dipilih sudah ada hero, maka return false
            // cek apakah listTiles sudah diisi lokasi
            if (tiles.tile.ContainsKey(tile) == true)
            {
                // CheckAvailabilityMoveTile(tile) akan bernilai false, artinya sudah ada hero di tile tersebut
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    /*
    public class Tile
    {
        List<int> tile = new List<int>();
    }
    */
}