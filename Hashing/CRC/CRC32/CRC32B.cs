using HashLib;

namespace SimpleHashing.CRC.CRC32
{
    public class CRC32B
    {
        private static IHash _processor = HashFactory.Checksum.CreateCRC32b();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}