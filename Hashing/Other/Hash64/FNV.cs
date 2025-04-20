using HashLib;

namespace SimpleHashing.Other.Hash64
{
    public class FNV
    {
        private static IHash _processor = HashFactory.Hash64.CreateFNV();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}