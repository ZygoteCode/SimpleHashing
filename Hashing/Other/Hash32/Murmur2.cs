using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class Murmur2
    {
        private static IHash _processor = HashFactory.Hash32.CreateMurmur2();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}