using HashLib;

namespace SimpleHashing.MD
{
    public class MD2
    {
        private static IHash _processor = HashFactory.Crypto.CreateMD2();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}