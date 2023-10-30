using HashLib;

namespace SimpleHashing.Snefru
{
    public class Snefru_4_256
    {
        private static IHash _processor = HashFactory.Crypto.CreateSnefru_4_256();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}