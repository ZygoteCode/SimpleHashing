using HashLib;

namespace SimpleHashing.MD
{
    public class MD5
    {
        private static IHash _processor = HashFactory.Crypto.CreateMD5();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}