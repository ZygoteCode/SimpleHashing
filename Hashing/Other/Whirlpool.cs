using HashLib;

namespace SimpleHashing.Other
{
    public class Whirlpool
    {
        private static IHash _processor = HashFactory.Crypto.CreateWhirlpool();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}