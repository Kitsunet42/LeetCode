public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int res = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            long sum = 0;
            for (int t = i; t < nums.Length; t++)
            {
                sum += nums[t];
                if (sum == k) 
                {
                    res++;
                }
            }
        }
        return res;
    }
}