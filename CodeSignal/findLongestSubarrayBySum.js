function findLongestSubarrayBySum(s, arr) {
    let l = 0, r = 0, sum = arr[0], len = 1;
    let sol = { l : 0, r : 0, len : -1 };
    
    while (true) {
        if (r >= arr.length || l > r) {
            break;
        }
        
        if (sum == s) {
            if ((r-l+1) > sol.len) {
                sol.len = (r-l+1); sol.l = l; sol.r = r;
            }
            sum += arr[++r];
        } else if (sum > s) {
            sum -= arr[l++];
            r = Math.max(l, r);
        } else if (sum < s) {
            sum += arr[++r];
        }        
    }
    
    return sol.len === -1 ? [-1] : [sol.l + 1, sol.r + 1];
}

let s = 0
let arr = [1, 0, 2];

findLongestSubarrayBySum(s, arr);
// 2, 2