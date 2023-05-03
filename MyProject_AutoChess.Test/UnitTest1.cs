using MyProject_AutoChess;
using Xunit;
namespace MyProject_AutoChess.Test;

public class UnitTest1
{   

    [Fact]
    public void TestAddPlayers()
    {
        // Arrange
        Game gameTest = new Game();
        gameTest.AddPlayers("Gilang", "Enemy");

        // Act
        string actualResult = gameTest.AddPlayers("Gilang", "Enemy");
        string expectedResult = "Player 1: Gilang dan Player 2: Enemy telah ditambahkan";

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestShowListPlayers()
    {
        Game gameTest = new Game();
        gameTest.AddPlayers("Gilang", "Enemy");

        string actualResult = gameTest.ShowListPlayer();
        string expectedResult = "\nPlayer 1: Gilang"+
                                "\nPlayer 2: Enemy";

        Assert.Equal(expectedResult, actualResult);


        //returnListPlayer.Append("\nPlayer "+ number + ": " + item.GetPlayerName());
    }

    [Fact]
    public void TestAddHeroToDeckPlayerOne()
    {
        Game gameTest = new Game();
        Players playerOne = gameTest._playerOne;
        string heroName = "Freya";
        int heroLocation = 12;

        string actualResult = gameTest.AddHeroToDeck(playerOne, heroName, heroLocation);
        string expectedResult = "Freya added to location 12";
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestFalseLocation_AddHeroToDeckPlayerOne()
    {
        Game gameTest = new Game();
        Players playerOne = gameTest._playerOne;
        string heroName = "Freya";
        int heroLocation = 27;

        string actualResult = gameTest.AddHeroToDeck(playerOne, heroName, heroLocation);
        string expectedResult = "Location must be between 1 and 24";
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestFalseHero_AddHeroToDeckPlayerOne()
    {
        Game gameTest = new Game();
        Players playerOne = gameTest._playerOne;
        string heroName = "Bobon";
        int heroLocation = 12;

        string actualResult = gameTest.AddHeroToDeck(playerOne, heroName, heroLocation);
        string expectedResult = $"Hero {heroName} not found";

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestRemoveHeroFromDeck()
    {
        Game gameTest = new Game();
        Players playerOne = gameTest._playerOne;
        string heroName = "garo";
        int heroLocation = 1;

        // fill deck with hero
        gameTest.AddHeroToDeck(playerOne, heroName, heroLocation);

        string actualResult = gameTest.RemoveHeroFromDeck(playerOne, heroName, heroLocation);
        string expectedResult = $"Hero '{heroName}' with location 1 removed from deck";

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestFalseHeroLocation_RemoveHeroFromDeck()
    {
        Game gameTest = new Game();
        Players playerOne = gameTest._playerOne;
        string heroName = "garo";
        int heroLocation = 1;

        // fill deck with hero
        gameTest.AddHeroToDeck(playerOne, heroName, heroLocation);

        string actualResult = gameTest.RemoveHeroFromDeck(playerOne, heroName, 2);
        string expectedResult = $"Hero '{heroName}' with location 2 not found";

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestFalseHeroName_RemoveHeroFromDeck()
    {
        Game gameTest = new Game();
        Players playerOne = gameTest._playerOne;
        string heroName = "suhu";
        int heroLocation = 1;

        // fill deck with hero
        gameTest.AddHeroToDeck(playerOne, heroName, heroLocation);

        string actualResult = gameTest.RemoveHeroFromDeck(playerOne, heroName, 1);
        string expectedResult = $"Hero '{heroName}' with location 1 not found";

        Assert.Equal(expectedResult, actualResult);
    }

}