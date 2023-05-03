namespace MyProject_AutoChess
{
    public class Board
    {
        // properties
        public Tile tiles = new Tile();
        public bool CheckAvailabilityMoveTile(int tileInput) =>
            tiles.tile.ContainsKey(tileInput) ? false : true;
    }
}