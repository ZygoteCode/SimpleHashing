using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Wy
{
    public class Wy64
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new WyHash64().ComputeHash(data);
        }
    }
}