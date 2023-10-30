using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.FastPositive
{
    public class FastPositiveV0
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new FastPositiveHash(FastPositiveHashVariant.V0).ComputeHash(data);
        }
    }
}