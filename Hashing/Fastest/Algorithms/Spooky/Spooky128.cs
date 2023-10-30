using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Spooky
{
    public class Spooky128
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new SpookyHash128().ComputeHash(data);
        }
    }
}