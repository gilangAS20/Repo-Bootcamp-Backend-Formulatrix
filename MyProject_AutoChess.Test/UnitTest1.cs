using MyProject_AutoChess;
using Xunit;
namespace MyProject_AutoChess.Test;

public class UnitTest1
{
    //Game gameTest = new Game();

    [Fact]
    public void TestGetBoardSize()
    {
        //Arange
        Game gameTest = new Game();
        int boardSize = 24;

        //Act
        gameTest.SetBoardSize(boardSize);
        int actualResult = gameTest.GetBoardSize();
        int expectedResult = boardSize;

        //Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestAddPlayers()
    {
        // Arrange
        Game gameTest = new Game();


        // Act
        string actualResult = gameTest.AddPlayers("Gilang", "Enemy");
        string expectedResult = "Player 1: Gilang dan Player 2: Enemy telah ditambahkan";

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestAddPlayersTwoTimes()
    {
        // Arrange
        Game gameTest = new Game();
        //gameTest.AddPlayers("Gilang", "Enemy");

        // Act
        string actualResultOne = gameTest.AddPlayers("Gilang", "Enemy");
        string actualResultTwo = gameTest.AddPlayers("Suhu", "Enemiiii");
        string expectedResultOne = "Player 1: Gilang dan Player 2: Enemy telah ditambahkan";
        string expectedResultTwo = "Player sudah penuh";

        // Assert
        Assert.Equal(expectedResultOne, actualResultOne);
        Assert.Equal(expectedResultTwo, actualResultTwo);
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
    }

    [Fact]
    public void TestAddHeroToDeckPlayerOne()
    {
        Game gameTest = new Game();
        Players playerOne = gameTest._playerOne;
        gameTest.SetBoardSize(24);
        
        string heroNameOne = "Freya";
        int heroLocationOne = 12;
        string actualResultOne = gameTest.AddHeroToDeck(playerOne, heroNameOne, heroLocationOne);
        string expectedResultOne = "Freya added to location 12";

        string heroNameTwo = "Garo";
        int heroLocationTwo = 12;
        string actualResultTwo = gameTest.AddHeroToDeck(playerOne, heroNameTwo, heroLocationTwo);
        string expectedResultTwo = "Location 12 is already used by other hero";

        string heroNameThree = "Asus";
        int heroLocationThree = 13;
        string actualResultThree = gameTest.AddHeroToDeck(playerOne, heroNameThree, heroLocationThree);
        string expectedResultThree = "Hero Asus not found";

        string heroNameFour = "Stella";
        int heroLocationFour = 30;
        string actualResultFour = gameTest.AddHeroToDeck(playerOne, heroNameFour, heroLocationFour);
        string expectedResultFour = "Location must be between 1 and 24";

        Assert.Equal(expectedResultOne, actualResultOne);
        Assert.Equal(expectedResultTwo, actualResultTwo);
        Assert.Equal(expectedResultThree, actualResultThree);
        Assert.Equal(expectedResultFour, actualResultFour);
    }

    [Fact]
    public void TestRemoveHeroFromDeck()
    {
        Game gameTest = new Game();
        Players playerOne = gameTest._playerOne;
        gameTest.SetBoardSize(24);
        int boardSize = gameTest.GetBoardSize();
        
        string heroNameOne = "garo";
        int heroLocationOne = 1;
        gameTest.AddHeroToDeck(playerOne, heroNameOne, heroLocationOne);
        string actualResultOne = gameTest.RemoveHeroFromDeck(playerOne, heroNameOne, heroLocationOne);
        string expectedResultOne = $"Hero '{heroNameOne}' with location 1 removed from deck";

        string heroNameTwo = "garo";
        int heroLocationTwo = 2;
        gameTest.AddHeroToDeck(playerOne, heroNameTwo, heroLocationTwo);
        string actualResultTwo = gameTest.RemoveHeroFromDeck(playerOne, heroNameTwo, 3);
        string expectedResultTwo = $"Hero '{heroNameTwo}' with location 3 not found";


        string heroNameThree = "Stella";
        int heroLocationThree = 3;
        gameTest.AddHeroToDeck(playerOne, heroNameThree, heroLocationThree);
        string actualResultThree = gameTest.RemoveHeroFromDeck(playerOne, heroNameThree);
        string expectedResultThree = "Location must be filled";

        string heroNameFour = "Freya";
        int heroLocationFour = 12;
        gameTest.AddHeroToDeck(playerOne, heroNameFour, heroLocationFour);
        string actualResultFour = gameTest.RemoveHeroFromDeck(playerOne, heroNameFour, 99);
        string expectedResultFour = $"Location must be between 1 and {boardSize}";

        Assert.Equal(expectedResultOne, actualResultOne);
        Assert.Equal(expectedResultTwo, actualResultTwo);
        Assert.Equal(expectedResultThree, actualResultThree);
        Assert.Equal(expectedResultFour, actualResultFour);
    }
}