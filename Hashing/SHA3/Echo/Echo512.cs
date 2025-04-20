using HashLib;

namespace SimpleHashing.SHA3.Echo
{
    public class Echo512
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateEcho512();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}