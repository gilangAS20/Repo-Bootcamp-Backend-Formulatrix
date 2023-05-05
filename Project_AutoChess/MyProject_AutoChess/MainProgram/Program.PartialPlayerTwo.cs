namespace MyProject_AutoChess;

public partial class Program
{
    public static void InitializePlayerTwo(Game game)
    {
        // ==================================player2===========================================
        System.Console.WriteLine("\n=====================player2======================");

        // menambahkan hero player2 ke dalam deck
        System.Console.WriteLine("--add hero to Enemy's deck--");
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "garo", 1));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "garo", 2));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "stella", 3));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "stella", 17));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "plankton", 4)); // fail karena nama hero tidak ada
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "freya", 21));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "freya", 24));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "freya", 3)); // fail karena lokasi sudah digunakan
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "freya", 0)); // fail karena lokasi harus antara 1 dan 24

        // menampilkan deck Enemy (player2)
        System.Console.WriteLine("\n--show Enemy's deck--");
        System.Console.WriteLine(game.ShowDeck(game._playerTwo));

        // tes delete hero player2 dari dalam deck
        System.Console.WriteLine("\nDelete hero from Enemy's deck: ");
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerTwo, "garo", 1));
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerTwo, "garo", 12));
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerTwo, "stella", 25));
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerTwo, "suhu", 17));

        // menampilkan deck Enemy (player2) setelah remove
        System.Console.WriteLine("\nDeck Enemy(after remove): ");
        System.Console.WriteLine(game.ShowDeck(game._playerTwo));

        // menambahkan kembali hero player2 ke dalam deck
        System.Console.WriteLine("\n--add hero to Enemy's deck--");
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "garo", 1));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerTwo, "freya", 6));

        // menampilkan deck Enemy (player2)
        System.Console.WriteLine("\n--show Enemy's deck--");
        System.Console.WriteLine(game.ShowDeck(game._playerTwo));

        System.Console.WriteLine("==================================================");
        // ====================================================================================
    }
}
