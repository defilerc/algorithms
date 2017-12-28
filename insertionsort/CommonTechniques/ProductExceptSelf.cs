namespace Algo.CommonTechniques
{
    public class ProductExceptSelf
    {
        public int productExceptSelf(int[] nums, int m)
        {
            var f = new int[nums.Length];

            var prefixProd = new int[nums.Length];
            var suffixProd = new int[nums.Length];

            prefixProd[0] = suffixProd[nums.Length - 1] = 1;

            for (int i = 1; i < nums.Length; i++) {
                prefixProd[i] = (prefixProd[i - 1] * nums[i - 1]) % m;
                suffixProd[nums.Length - 1 - i] = 
                    (suffixProd[nums.Length - i] * nums[nums.Length - i]) % m;
            }

            var g = 0;
            for (var i = 0; i < nums.Length; i++) {
                f[i] = (prefixProd[i] * suffixProd[i]) % m;
                g += f[i];
            }

            return g % m;
        }

    }
}

