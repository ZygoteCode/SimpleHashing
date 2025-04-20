using HashLib;

namespace SimpleHashing.SHA3.Hamsi
{
    public class Hamsi384
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateHamsi384();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}