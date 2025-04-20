using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class JS
    {
        private static IHash _processor = HashFactory.Hash32.CreateJS();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}