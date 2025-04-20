using HashLib;

namespace SimpleHashing.SHA3.SIMD
{
    public class SIMD256
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateSIMD256();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}