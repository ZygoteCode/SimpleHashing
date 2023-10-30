using HashLib;

namespace SimpleHashing.SHA3.Fugue
{
    public class Fugue224
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateFugue224();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}