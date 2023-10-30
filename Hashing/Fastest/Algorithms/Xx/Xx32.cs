using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Xx
{
    public class Xx32
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new XxHash32().ComputeHash(data);
        }
    }
}