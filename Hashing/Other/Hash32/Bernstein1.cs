using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class Bernstein1
    {
        private static IHash _processor = HashFactory.Hash32.CreateBernstein1();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}