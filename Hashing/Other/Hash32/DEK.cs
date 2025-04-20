using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class DEK
    {
        private static IHash _processor = HashFactory.Hash32.CreateDEK();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}