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

        else if (n == 100)
        {
            return "C";
        }
        else if (n == 200)
        {
            return "CC";
        }
        else if (n == 300)
        {
            return "CCC";
        }
        else if (n == 400)
        {
            return "CD";
        }
        else if (n == 500)
        {
            return "D";
        }
        else if (n == 600)
        {
            return "DC";
        }
        else if (n == 700)
        {
            return "DCC";
        }
        else if (n == 800)
        {
            return "DCCC";
        }
        else if (n == 900)
        {
            return "CM";
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
}