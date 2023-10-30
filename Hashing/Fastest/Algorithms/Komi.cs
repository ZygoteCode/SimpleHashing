using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest
{
    public class Komi
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new KomiHash().ComputeHash(data);
        }
    }
}