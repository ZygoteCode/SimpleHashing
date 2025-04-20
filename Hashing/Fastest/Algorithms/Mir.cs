using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest
{
    public class Mir
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new MirHash().ComputeHash(data);
        }
    }
}