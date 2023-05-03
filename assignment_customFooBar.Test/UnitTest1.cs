using CustomFooBar;
namespace assignment_customFooBar.Test;

public class UnitTest1
{
    [Theory]
    [InlineData(3, "foo", "Add dictionary with Key: 3, Value: foo", true)]
    [InlineData(5, "bar", "Add dictionary with Key: 5, Value: foo", true)]
    //[InlineData(7, "zoo")]
    public void TestAddKeyValue(int angka, string karakter, string expected, bool expectedBool)
    {
        Operation testAddKeyValue = new();

        (string, bool) actual = testAddKeyValue.AddKeyValue(angka, karakter);

        Assert.Equal(expected, actual.Item1); // ini cek string-nya
        Assert.Equal(expectedBool, actual.Item2); // ini cek true false-nya
    }
}