public static class Converter
{
    public static string ToRoman(int n)
    {
        var result = "";
        Enumerable
            .Range(1, n.ToString().Length)
            .ToList()
            .ForEach(numOfDigits =>
            {
                var number = n % (int)Math.Pow(10, numOfDigits);
                switch (numOfDigits)
                {
                    case 1:
                        result = result.Insert(0, HandleOneDigit(number));
                        break;
                    case 2:
                        result = result.Insert(0, HandleTwoDigits(number));
                        break;
                    case 3:
                        result = result.Insert(0, HandleThreeDigits(number));
                        break;
                    default:
                        result = result.Insert(0, HandleFourDigits(number));
                        break;
                }

                n -= number;
            });

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
            9 => "IX",
            _ => ""
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
            90 => "XC",
            _ => ""
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
            900 => "CM",
            _ => ""
        };
    }

    private static string HandleFourDigits(int n)
    {
        return n switch
        {
            1000 => "M",
            2000 => "MM",
            3000 => "MMM",
            _ => ""
        };
    }
}