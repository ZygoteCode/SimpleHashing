using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Xx
{
    public class Xx64
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new XxHash64().ComputeHash(data);
        }
    }
}