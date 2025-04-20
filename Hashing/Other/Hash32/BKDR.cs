using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class BKDR
    {
        private static IHash _processor = HashFactory.Hash32.CreateBKDR();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}