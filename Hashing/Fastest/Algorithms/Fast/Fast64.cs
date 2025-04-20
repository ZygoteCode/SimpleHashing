using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Fast
{
    public class Fast64
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new FastHash64().ComputeHash(data);
        }
    }
}