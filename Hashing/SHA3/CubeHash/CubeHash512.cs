using HashLib;

namespace SimpleHashing.SHA3.CubeHash
{
    public class CubeHash512
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateCubeHash512();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}