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

    [Fact]
    public void Converts_6_to_roman_VI()
    {
        var actual = Converter.ToRoman(6);
        Assert.Equal("VI", actual);
    }

    [Fact]
    public void Converts_7_to_roman_VII()
    {
        var actual = Converter.ToRoman(7);
        Assert.Equal("VII", actual);
    }

    [Fact]
    public void Converts_8_to_roman_VIII()
    {
        var actual = Converter.ToRoman(8);
        Assert.Equal("VIII", actual);
    }

    [Fact]
    public void Converts_9_to_roman_IX()
    {
        var actual = Converter.ToRoman(9);
        Assert.Equal("IX", actual);
    }

    [Fact]
    public void Converts_10_to_roman_X()
    {
        var actual = Converter.ToRoman(10);
        Assert.Equal("X", actual);
    }

    [Fact]
    public void Converts_20_to_roman_XX()
    {
        var actual = Converter.ToRoman(20);
        Assert.Equal("XX", actual);
    }

    [Fact]
    public void Converts_30_to_roman_XXX()
    {
        var actual = Converter.ToRoman(30);
        Assert.Equal("XXX", actual);
    }

    [Fact]
    public void Converts_40_to_roman_XL()
    {
        var actual = Converter.ToRoman(40);
        Assert.Equal("XL", actual);
    }

    [Fact]
    public void Converts_50_to_roman_L()
    {
        var actual = Converter.ToRoman(50);
        Assert.Equal("L", actual);
    }

    [Fact]
    public void Converts_60_to_roman_LX()
    {
        var actual = Converter.ToRoman(60);
        Assert.Equal("LX", actual);
    }

    [Fact]
    public void Converts_70_to_roman_LXX()
    {
        var actual = Converter.ToRoman(70);
        Assert.Equal("LXX", actual);
    }

    [Fact]
    public void Converts_80_to_roman_LXXX()
    {
        var actual = Converter.ToRoman(80);
        Assert.Equal("LXXX", actual);
    }

    [Fact]
    public void Converts_90_to_roman_XC()
    {
        var actual = Converter.ToRoman(90);
        Assert.Equal("XC", actual);
    }

    [Fact]
    public void Converts_100_to_roman_C()
    {
        var actual = Converter.ToRoman(100);
        Assert.Equal("C", actual);
    }

    [Fact]
    public void Converts_200_to_roman_CC()
    {
        var actual = Converter.ToRoman(200);
        Assert.Equal("CC", actual);
    }
}