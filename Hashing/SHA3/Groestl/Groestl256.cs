using HashLib;

namespace SimpleHashing.SHA3.Groestl
{
    public class Groestl256
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateGroestl256();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}