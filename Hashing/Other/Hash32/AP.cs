using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class AP
    {
        private static IHash _processor = HashFactory.Hash32.CreateAP();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}