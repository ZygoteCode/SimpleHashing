using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest
{
    public class HalfSip
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new HalfSipHash().ComputeHash(data);
        }
    }
}