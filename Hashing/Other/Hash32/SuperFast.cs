using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class SuperFast
    {
        private static IHash _processor = HashFactory.Hash32.CreateSuperFast();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}