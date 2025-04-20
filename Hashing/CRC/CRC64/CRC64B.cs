using HashLib;

namespace SimpleHashing.CRC.CRC64
{
    public class CRC64B
    {
        private static IHash _processor = HashFactory.Checksum.CreateCRC64b();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}