using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest
{
    public class Mx3
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new Mx3Hash().ComputeHash(data);
        }
    }
}