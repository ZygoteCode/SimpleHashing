using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class SDBM
    {
        private static IHash _processor = HashFactory.Hash32.CreateSDBM();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}