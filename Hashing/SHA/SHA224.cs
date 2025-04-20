using HashLib;

namespace SimpleHashing.SHA
{
    public class SHA224
    {
        private static IHash _processor = HashFactory.Crypto.CreateSHA224();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}