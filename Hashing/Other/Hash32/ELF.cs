using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class ELF
    {
        private static IHash _processor = HashFactory.Hash32.CreateELF();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}