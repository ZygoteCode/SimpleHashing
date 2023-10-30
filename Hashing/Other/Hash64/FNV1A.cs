using HashLib;

namespace SimpleHashing.Other.Hash64
{
    public class FNV1A
    {
        private static IHash _processor = HashFactory.Hash64.CreateFNV1a();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}