using HashLib;

namespace SimpleHashing.SHA3.Skein
{
    public class Skein256
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateSkein256();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}