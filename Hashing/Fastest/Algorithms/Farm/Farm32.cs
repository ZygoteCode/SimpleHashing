using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Farm
{
    public class Farm32
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new FarmHash32().ComputeHash(data);
        }
    }
}