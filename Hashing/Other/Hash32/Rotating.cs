using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class Rotating
    {
        private static IHash _processor = HashFactory.Hash32.CreateRotating();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}