using HashLib;

namespace SimpleHashing.SHA3.Groestl
{
    public class Groestl512
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateGroestl512();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}