namespace MyProject_AutoChess;

public partial class Program
{
    public static void InitializePlayerOne(Game game)
    {
        // ==================================player1===========================================
        System.Console.WriteLine("\n=====================player1======================");

        // menambahkan hero player1 ke dalam deck
        System.Console.WriteLine("--add hero to Gilang's deck--");
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "freya", 24));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "garo", 2));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "stella", 22));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "stella", 19));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "garo", 12)); // hilangkan command code jika mau cek winner dengan totalHP tertinggi
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "stella", 2)); // fail karena lokasi sudah digunakan
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "stella", 30)); // fail karena lokasi harus antara 1-24
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "slebew", 4)); // fail karena hero tidak ada

        // menampilkan deck Gilang (player1)
        System.Console.WriteLine("\n--show Gilang's deck--");
        System.Console.WriteLine(game.ShowDeck(game._playerOne));

        // tes delete hero player1 dari dalam deck
        System.Console.WriteLine("\nDelete hero from Gilang's deck: ");
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerOne, "garo", 25));
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerOne, "garo")); // location cannot be empty
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerOne, "garo", 12));
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerOne, "stella", 19));
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerOne, "freya", 2));
        System.Console.WriteLine(game.RemoveHeroFromDeck(game._playerOne, "Shiro"));

        // menampilkan deck Gilang (player1) setelah remove
        System.Console.WriteLine("\nDeck Gilang(after remove): ");
        System.Console.WriteLine(game.ShowDeck(game._playerOne));

        // menambahkan kembali hero player1 ke dalam deck
        System.Console.WriteLine("\n--add hero to Gilang's deck--");
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "freya", 1));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "stella", 2));
        System.Console.WriteLine(game.AddHeroToDeck(game._playerOne, "stella", 19));

        // menampilkan deck Gilang (player1)
        System.Console.WriteLine("\n--show Gilang's deck--");
        System.Console.WriteLine(game.ShowDeck(game._playerOne));

        System.Console.WriteLine("==================================================");
    }
}
