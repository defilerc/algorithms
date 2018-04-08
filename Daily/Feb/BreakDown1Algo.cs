namespace Daily.Feb
{
    public class BreakDown1Algo
    {
        public bool breakDown1(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++) {
                for (var j = 0; j < arr.Length; j++) {
                    if (i == j) continue;

                    if (GCD(arr[i], arr[j]) != 1) {
                        return false;
                    }
                }
            }

            return true;
        }

        static int GCD(int a, int b)
        {
            while (a != 0 && b != 0) {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }

    }
}
