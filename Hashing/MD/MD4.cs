using HashLib;

namespace SimpleHashing.MD
{
    public class MD4
    {
        private static IHash _processor = HashFactory.Crypto.CreateMD4();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}