using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Highway
{
    public class Highway64
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new HighwayHash64().ComputeHash(data);
        }
    }
}