using HashLib;

namespace SimpleHashing.SHA3.BlueMidnightWish
{
    public class BlueMidnightWish256
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateBlueMidnightWish256();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}