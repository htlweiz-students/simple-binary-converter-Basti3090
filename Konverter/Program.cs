namespace Konverter;

public class BinaryConverter
{
    public static uint ToDecimal(string b)
    {
        return Convert.ToUInt32(b, 2);
    }
}


