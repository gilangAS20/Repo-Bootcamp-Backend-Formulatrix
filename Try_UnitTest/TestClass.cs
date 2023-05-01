using Xunit;

public class TestClass
{   
    [Fact] /*menandakan bahwa method dibawah ini adalah unit test
             functinal, artinya yaitu bagian dari unit test dan
             harus dijalankan, akan berisi asumsi untuk menguji
             block code*/
    public void PassingAddTest()
    {   
    //  Assert.Equal(expected value, actual value);
        Assert.Equal(4, Program.Add(2, 2)); // benar
        //Assert.Equal(5, Program.Add(2, 2)); // salah
    }


    [Fact]
    public void FailingTest()
    {
        Assert.NotEqual(5, Program.Add(2, 2));
    }

    [Theory] /*menggunakan [Theory] berarti ada beberapa
               argumen yang bisa dimasukkan sekaligus*/
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(6)] // salah
    //[InlineData(7)]
    public void MyFirstTheory(int myNumber)
    {
        Assert.True(Program.IsOdd(myNumber));
    }
}
