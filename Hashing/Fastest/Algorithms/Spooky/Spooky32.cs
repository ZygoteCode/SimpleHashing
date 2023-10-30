using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Spooky
{
    public class Spooky32
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new SpookyHash32().ComputeHash(data);
        }
    }
}