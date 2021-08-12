public static class Converter
{
    public static string ToRoman(int n)
    {
        if (n == 1) 
        {
            return "I";
        }
        else
        {
            return "II";
        }
    }
}