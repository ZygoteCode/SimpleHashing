using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.MetroV1
{
    public class MetroV1_64
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new MetroHash64(MetroHashVariant.V1).ComputeHash(data);
        }
    }
}