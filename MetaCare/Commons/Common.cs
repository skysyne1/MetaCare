using OtpNet;
using System;

namespace MetaCare.Commons
{
    public class Common
    {
        public static string GetCode(string key2fa)
        {
            byte[] secretKey = Base32Encoding.ToBytes(key2fa.Trim().Replace(" ", ""));
            Totp totp = new Totp(secretKey);
            return totp.ComputeTotp(DateTime.UtcNow);
        }

        public static bool IsDateTimeOffset(string input)
        {
            return DateTimeOffset.TryParse(input, out _);
        }

        public static bool IsUnixTimestamp(string input)
        {
            if (long.TryParse(input, out long timestamp))
            {
                return timestamp > 0 && timestamp < 253402300799;
            }
            return false;
        }

    }
}
