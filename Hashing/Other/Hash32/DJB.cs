using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class DJB
    {
        private static IHash _processor = HashFactory.Hash32.CreateDJB();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}