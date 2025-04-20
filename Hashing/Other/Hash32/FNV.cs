using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class FNV
    {
        private static IHash _processor = HashFactory.Hash32.CreateFNV();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}