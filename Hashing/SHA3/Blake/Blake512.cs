using HashLib;

namespace SimpleHashing.SHA3.Blake
{
    public class Blake512
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateBlake512();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}