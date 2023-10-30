using HashLib;

namespace SimpleHashing.Other
{
    public class Adler32
    {
        private static IHash _processor = HashFactory.Checksum.CreateAdler32();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}