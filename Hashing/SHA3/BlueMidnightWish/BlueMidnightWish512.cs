using HashLib;

namespace SimpleHashing.SHA3.BlueMidnightWish
{
    public class BlueMidnightWish512
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateBlueMidnightWish512();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}