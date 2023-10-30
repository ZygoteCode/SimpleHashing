using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class FNV1A
    {
        private static IHash _processor = HashFactory.Hash32.CreateFNV1a();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}