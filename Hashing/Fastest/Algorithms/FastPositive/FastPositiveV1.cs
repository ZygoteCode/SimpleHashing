using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.FastPositive
{
    public class FastPositiveV1
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new FastPositiveHash(FastPositiveHashVariant.V1).ComputeHash(data);
        }
    }
}