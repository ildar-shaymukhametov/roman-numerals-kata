public static class Converter
{
    public static string ToRoman(int n)
    {
        var left = n;
        var incr = 10;
        var result = "";
        while (left > 0)
        {
            var number = left % incr;
            if (number == 0)
            {
                incr *= 10;
                continue;
            }

            switch (incr)
            {
                case 10:
                    result = result.Insert(0, HandleOneDigit(number));
                    break;
                case 100:
                    result = result.Insert(0, HandleTwoDigits(number));
                    break;
                case 1000:
                    result = result.Insert(0, HandleThreeDigits(number));
                    break;
                default:
                    result = result.Insert(0, HandleFourDigits(number));
                    break;
            }

            left -= number;
            incr *= 10;
        }

        return result;
    }

    private static string HandleOneDigit(int n)
    {
        return n switch
        {
            1 => "I",
            2 => "II",
            3 => "III",
            4 => "IV",
            5 => "V",
            6 => "VI",
            7 => "VII",
            8 => "VIII",
            _ => "IX"
        };
    }

    private static string HandleTwoDigits(int n)
    {
        return n switch
        {
            10 => "X",
            20 => "XX",
            30 => "XXX",
            40 => "XL",
            50 => "L",
            60 => "LX",
            70 => "LXX",
            80 => "LXXX",
            _ => "XC"
        };
    }

    private static string HandleThreeDigits(int n)
    {
        return n switch
        {
            100 => "C",
            200 => "CC",
            300 => "CCC",
            400 => "CD",
            500 => "D",
            600 => "DC",
            700 => "DCC",
            800 => "DCCC",
            _ => "CM"
        };
    }

    private static string HandleFourDigits(int n)
    {
        return n switch
        {
            1000 => "M",
            2000 => "MM",
            _ => "MMM",
        };
    }
}