using HashLib;

namespace SimpleHashing.SHA3.Luffa
{
    public class Luffa384
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateLuffa384();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}