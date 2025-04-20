using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest
{
    public class Pengy
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new PengyHash().ComputeHash(data);
        }
    }
}