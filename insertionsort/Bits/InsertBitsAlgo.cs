namespace Algo.Bits
{
    public class InsertBitsAlgo
    {
        public int insertBits(int n, int a, int b, int k)
        {
            int bitmask = (1 << b + 1) - (1 << a);

            n &= ~bitmask;
            k <<= a;

            n |= k;

            return n;
        }

    }
}
