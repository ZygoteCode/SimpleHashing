using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class Bernstein
    {
        private static IHash _processor = HashFactory.Hash32.CreateBernstein();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}