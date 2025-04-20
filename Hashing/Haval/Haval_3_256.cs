using HashLib;

namespace SimpleHashing.Haval
{
    public class Haval_3_256
    {
        private static IHash _processor = HashFactory.Crypto.CreateHaval_3_256();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}