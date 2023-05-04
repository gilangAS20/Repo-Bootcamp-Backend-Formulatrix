namespace MyProject_AutoChess
{
    public class Board
    {
        // properties
        public Tile tiles = new Tile();

        public bool CheckAvailabilityTile(int tileInput)
        {
            if(tiles.tile.ContainsKey(tileInput) == true)
            {
                return false;
            }
            
            else
            {
                return true;
            }
        }
    }
}