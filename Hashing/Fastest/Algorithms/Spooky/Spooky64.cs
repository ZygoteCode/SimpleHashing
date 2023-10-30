using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Spooky
{
    public class Spook64
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new SpookyHash64().ComputeHash(data);
        }
    }
}