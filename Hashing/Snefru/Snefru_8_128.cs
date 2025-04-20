using HashLib;

namespace SimpleHashing.Snefru
{
    public class Snefru_8_128
    {
        private static IHash _processor = HashFactory.Crypto.CreateSnefru_8_128();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}