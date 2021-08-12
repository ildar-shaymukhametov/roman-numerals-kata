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

    [Fact]
    public void Converts_3_to_roman_III()
    {
        var actual = Converter.ToRoman(3);
        Assert.Equal("III", actual);
    }

    [Fact]
    public void Converts_4_to_roman_IV()
    {
        var actual = Converter.ToRoman(4);
        Assert.Equal("IV", actual);
    }

    [Fact]
    public void Converts_5_to_roman_V()
    {
        var actual = Converter.ToRoman(5);
        Assert.Equal("V", actual);
    }
}