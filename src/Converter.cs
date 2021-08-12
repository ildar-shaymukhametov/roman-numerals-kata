public static class Converter
{
    public static string ToRoman(int n)
    {
        if (n >= 1 && n <= 9)
        {
            return HandleOneDigit(n);
        }
        if (n >= 10 && n <= 99)
        {
            return HandleTwoDigits(n);
        }
        if (n >= 100 && n <= 999)
        {
            return HandleThreeDigits(n);
        }

        else if (n == 1000)
        {
            return "M";
        }
        else
        {
            return "MCMIII";
        }
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
}