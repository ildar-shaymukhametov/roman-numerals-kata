public static class Converter
{
    public static string ToRoman(int n)
    {
        if (n == 1) 
        {
            return "I";
        }
        else if (n == 2)
        {
            return "II";
        }
        else if (n == 3)
        {
            return "III";
        }
        else if (n == 4)
        {
            return "IV";
        }
        else
        {
            return "V";
        }
    }
}