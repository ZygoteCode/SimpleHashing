using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class DotNet
    {
        private static IHash _processor = HashFactory.Hash32.CreateDotNet();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}