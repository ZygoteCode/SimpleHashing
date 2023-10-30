using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Sip
{
    public class SipV1
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new SipHash(SipHashVariant.V13).ComputeHash(data);
        }
    }
}