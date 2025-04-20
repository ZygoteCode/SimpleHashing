using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class Jenkins3
    {
        private static IHash _processor = HashFactory.Hash32.CreateJenkins3();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}