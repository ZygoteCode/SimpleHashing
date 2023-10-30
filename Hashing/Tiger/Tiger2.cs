using HashLib;

namespace SimpleHashing.Tiger
{
    public class Tiger2
    {
        private static IHash _processor = HashFactory.Crypto.CreateTiger2();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}