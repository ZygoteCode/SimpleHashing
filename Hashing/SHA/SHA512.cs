using HashLib;

namespace SimpleHashing.SHA
{
    public class SHA512
    {
        private static IHash _processor = HashFactory.Crypto.CreateSHA512();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}