using HashLib;

namespace SimpleHashing.SHA3.JH
{
    public class JH256
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateJH256();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}