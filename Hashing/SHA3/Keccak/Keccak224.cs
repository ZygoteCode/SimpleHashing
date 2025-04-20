using HashLib;

namespace SimpleHashing.SHA3.Keccak
{
    public class Keccak224
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateKeccak224();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}