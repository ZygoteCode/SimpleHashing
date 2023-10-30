using HashLib;

namespace SimpleHashing.SHA3.SHAvite3
{
    public class SHAvite3_224
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateSHAvite3_224();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}