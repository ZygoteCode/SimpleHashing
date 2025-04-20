using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Fast
{
    public class Fast32
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new FastHash32().ComputeHash(data);
        }
    }
}