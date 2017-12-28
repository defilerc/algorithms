using System.Text;

namespace Algo
{
    public class IncrementCipher
    {
        public string incrementCipher(string s, int[] nums) {
    
            var r = new StringBuilder(s);

            for (var i = 0; i < nums.Length; i++) {
                for (var j = nums[i] - 1; j < s.Length; j += nums[i]) {
                    r[j] = r[j] == 'z' ? 'a' : (char)(r[j] + 1);
                }
            }

            return r.ToString();
        }

    }
}
