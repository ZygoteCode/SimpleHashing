using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.MetroV1
{
    public class MetroV2_64
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new MetroHash64(MetroHashVariant.V2).ComputeHash(data);
        }
    }
}