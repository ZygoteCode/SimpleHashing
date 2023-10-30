using HashLib;

namespace SimpleHashing.SHA3.CubeHash
{
    public class CubeHash384
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateCubeHash384();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}