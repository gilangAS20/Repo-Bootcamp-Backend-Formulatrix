namespace MyProject_AutoChess
{
    public class Board
    {
        // properties
        public Tile tiles = new Tile();
        public bool CheckAvailabilityMoveTile(int tileInput)
        {
            // cek apakah listTiles sudah diisi lokasi
            if (tiles.tile.ContainsKey(tileInput) == true)
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
}