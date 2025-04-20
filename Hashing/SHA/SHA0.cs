using SimpleHashing.SHA.SHA0Algo;

namespace SimpleHashing.SHA
{
    public class SHA0
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new BasicSHA0().ComputeHash(data);
        }
    }
}