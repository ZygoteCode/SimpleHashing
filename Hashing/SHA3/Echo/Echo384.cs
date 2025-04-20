using HashLib;

namespace SimpleHashing.SHA3.Echo
{
    public class Echo384
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateEcho384();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}