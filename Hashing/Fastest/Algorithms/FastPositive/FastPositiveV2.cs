using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.FastPositive
{
    public class FastPositiveV2
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new FastPositiveHash(FastPositiveHashVariant.V2).ComputeHash(data);
        }
    }
}