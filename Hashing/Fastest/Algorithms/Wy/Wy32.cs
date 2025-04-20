using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Wy
{
    public class Wy32
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new WyHash32().ComputeHash(data);
        }
    }
}