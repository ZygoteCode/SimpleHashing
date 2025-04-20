using HashLib;

namespace SimpleHashing.SHA3.SIMD
{
    public class SIMD224
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateSIMD224();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}