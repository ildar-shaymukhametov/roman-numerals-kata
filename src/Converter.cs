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
        else if (n == 5)
        {
            return "V";
        }
        else if (n == 6)
        {
            return "VI";
        }
        else if (n == 7)
        {
            return "VII";
        }
        else if (n == 8)
        {
            return "VIII";
        }
        else if (n == 9)
        {
            return "IX";
        }
        else if (n == 10)
        {
            return "X";
        }
        else if (n == 20)
        {
            return "XX";
        }
        else if (n == 30)
        {
            return "XXX";
        }
        else if (n == 40)
        {
            return "XL";
        }
        else if (n == 50)
        {
            return "L";
        }
        else if (n == 60)
        {
            return "LX";
        }
        else if (n == 70)
        {
            return "LXX";
        }
        else if (n == 80)
        {
            return "LXXX";
        }
        else if (n == 90)
        {
            return "XC";
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
}