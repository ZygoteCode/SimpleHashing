using HashLib;

namespace SimpleHashing.Other
{
    public class Gost
    {
        private static IHash _processor = HashFactory.Crypto.CreateGost();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}