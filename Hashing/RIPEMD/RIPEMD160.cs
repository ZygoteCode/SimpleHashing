using HashLib;

namespace SimpleHashing.RIPEMD
{
    public class RIPEMD160
    {
        private static IHash _processor = HashFactory.Crypto.CreateRIPEMD160();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}