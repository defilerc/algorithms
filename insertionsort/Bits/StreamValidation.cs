namespace AlgoTests.Bits
{
    public class StreamValidationAlgo
    {
        public bool streamValidation(int[] stream)
        {
            var remaining = 0;

            foreach (int s in stream) {

                if (remaining > 0) {
                    if ((s >> 6) != 2) {
                        return false;
                    }
                    remaining--;
                    continue;
                }

                if ((s >> 7) == 0) {
                    continue;
                }

                var head = s >> 3;

                if (head == 30) { // 11110
                    remaining = 3;
                    continue;
                }

                if (head >= 28 && head <= 29) {
                    // 1110X
                    remaining = 2;
                    continue;
                }

                if (head >= 24 && head <= 27) { // 110XX
                    remaining = 1;
                    continue;
                }

                return false;
            }

            return remaining == 0;
        }
    }
}
