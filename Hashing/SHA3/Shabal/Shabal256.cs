using HashLib;

namespace SimpleHashing.SHA3.Shabal
{
    public class Shabal256
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateShabal256();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}