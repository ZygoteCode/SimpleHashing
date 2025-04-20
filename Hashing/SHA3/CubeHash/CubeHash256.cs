using HashLib;

namespace SimpleHashing.SHA3.CubeHash
{
    public class CubeHash256
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateCubeHash256();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}