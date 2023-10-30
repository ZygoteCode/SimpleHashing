using HashLib;

namespace SimpleHashing.Other.Hash64
{
    public class Murmur2
    {
        private static IHash _processor = HashFactory.Hash64.CreateMurmur2();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}