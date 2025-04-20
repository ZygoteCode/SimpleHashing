using HashLib;

namespace SimpleHashing.RIPEMD
{
    public class RIPEMD256
    {
        private static IHash _processor = HashFactory.Crypto.CreateRIPEMD256();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}