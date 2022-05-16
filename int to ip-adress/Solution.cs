using System;
public class Kata
{
    public static string UInt32ToIP(uint ip)
    {
        string binary = Convert.ToString(ip, 2);
        binary = new string('0', 32 - binary.Length) + binary;

        return Convert.ToUInt32(binary[..8], 2) + "." +
               Convert.ToUInt32(binary[8..16], 2) + "." +
               Convert.ToUInt32(binary[16..24], 2) + "." +
               Convert.ToUInt32(binary[24..32], 2);

    }
}