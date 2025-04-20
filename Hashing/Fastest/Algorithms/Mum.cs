using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest
{
    public class Mum
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new MumHash().ComputeHash(data);
        }
    }
}