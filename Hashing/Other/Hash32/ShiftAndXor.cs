using HashLib;

namespace SimpleHashing.Other.Hash32
{
    public class ShiftAndXor
    {
        private static IHash _processor = HashFactory.Hash32.CreateShiftAndXor();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}