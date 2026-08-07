using System.Net;

namespace Unit_Testing_Examples
{
    public class IPAddressValidator
    {
        public static bool IsValidIP(string ipAddress)
        {
            return IPAddress.TryParse(ipAddress, out _);
        }
    }
}