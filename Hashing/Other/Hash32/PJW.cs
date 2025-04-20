using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class PJW
    {
        private static IHash _processor = HashFactory.Hash32.CreatePJW();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}