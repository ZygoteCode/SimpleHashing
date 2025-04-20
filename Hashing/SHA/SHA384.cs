using HashLib;

namespace SimpleHashing.SHA
{
    public class SHA384
    {
        private static IHash _processor = HashFactory.Crypto.CreateSHA384();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}