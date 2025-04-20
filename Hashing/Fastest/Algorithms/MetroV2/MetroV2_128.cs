using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.MetroV1
{
    public class MetroV2_128
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new MetroHash128(MetroHashVariant.V2).ComputeHash(data);
        }
    }
}