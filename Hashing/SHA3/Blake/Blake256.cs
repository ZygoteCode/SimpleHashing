using HashLib;

namespace SimpleHashing.SHA3.Blake
{
    public class Blake256
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateBlake256();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}