using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Highway
{
    public class Highway256
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new HighwayHash256().ComputeHash(data);
        }
    }
}