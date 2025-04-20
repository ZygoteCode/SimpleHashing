using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class RS
    {
        private static IHash _processor = HashFactory.Hash32.CreateRS();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}