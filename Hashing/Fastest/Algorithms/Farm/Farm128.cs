using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Farm
{
    public class Farm128
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new FarmHash128().ComputeHash(data);
        }
    }
}