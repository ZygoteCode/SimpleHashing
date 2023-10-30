using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Highway
{
    public class Highway128
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new HighwayHash128().ComputeHash(data);
        }
    }
}