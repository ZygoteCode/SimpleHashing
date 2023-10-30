namespace SimpleHashing.SHA.SHA0Algo
{
    internal enum PaddingType
    {
        Custom,
        OneZeroFillAnd8BytesMessageLengthLittleEndian,
        OneZeroFillAnd8BytesMessageLengthBigEndian,
        OneZeroFillAnd16BytesMessageLengthBigEndian
    }
}