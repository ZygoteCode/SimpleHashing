using HashLib;

namespace SimpleHashing.SHA3.Hamsi
{
    public class Hamsi512
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateHamsi512();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}