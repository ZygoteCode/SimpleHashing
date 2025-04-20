using SimpleHashing.Fastest.Base;

namespace SimpleHashing.Fastest.Sip
{
    public class SipV2
    {
        public static byte[] ComputeHash(byte[] data)
        {
            return new SipHash(SipHashVariant.V24).ComputeHash(data);
        }
    }
}