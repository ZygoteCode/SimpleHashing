using HashLib;

namespace SimpleHashing.SHA
{
    public class SHA256
    {
        private static IHash _processor = HashFactory.Crypto.CreateSHA256();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}