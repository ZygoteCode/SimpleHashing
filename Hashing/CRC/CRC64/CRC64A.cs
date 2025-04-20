using HashLib;

namespace SimpleHashing.CRC.CRC64
{
    public class CRC64A
    {
        private static IHash _processor = HashFactory.Checksum.CreateCRC64a();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}