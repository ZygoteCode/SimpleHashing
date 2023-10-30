using HashLib;

namespace SimpleHashing.SHA3.Shabal
{
    public class Shabal384
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateShabal384();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}