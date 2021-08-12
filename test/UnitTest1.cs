using Xunit;

namespace test;

public class UnitTest1
{
    [Fact]
    public void Converts_1_to_roman_I()
    {
        var actual = Converter.ToRoman(1);
        Assert.Equal("I", actual);
    }

    [Fact]
    public void Converts_2_to_roman_II()
    {
        var actual = Converter.ToRoman(2);
        Assert.Equal("II", actual);
    }
}