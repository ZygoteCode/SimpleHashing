using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class OneAtTime
    {
        private static IHash _processor = HashFactory.Hash32.CreateOneAtTime();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}