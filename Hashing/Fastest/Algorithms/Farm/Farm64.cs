using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Farm
{
    public class Farm64
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new FarmHash64().ComputeHash(data);
        }
    }
}