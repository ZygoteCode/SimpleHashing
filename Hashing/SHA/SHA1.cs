using HashLib;

namespace SimpleHashing.SHA
{
    public class SHA1
    {
        private static IHash _processor = HashFactory.Crypto.CreateSHA1();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}