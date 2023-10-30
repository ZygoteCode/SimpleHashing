using HashLib;

namespace SimpleHashing.RIPEMD
{
    public class RIPEMD320
    {
        private static IHash _processor = HashFactory.Crypto.CreateRIPEMD320();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}