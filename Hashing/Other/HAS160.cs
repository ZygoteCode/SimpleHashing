using HashLib;

namespace SimpleHashing.Other
{
    public class HAS160
    {
        private static IHash _processor = HashFactory.Crypto.CreateHAS160();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}