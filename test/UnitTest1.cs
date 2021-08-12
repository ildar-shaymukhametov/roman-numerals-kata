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
}