using HashLib;

namespace SimpleHashing.RIPEMD
{
    public class RIPEMD128
    {
        private static IHash _processor = HashFactory.Crypto.CreateRIPEMD128();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}