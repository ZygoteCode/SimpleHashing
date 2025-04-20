using HashLib;

namespace SimpleHashing.CRC.CRC32
{
    public class CRC32A
    {
        private static IHash _processor = HashFactory.Checksum.CreateCRC32a();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}