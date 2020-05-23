public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();
        int[] ans = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(target - nums[i]))
            {
                ans[0] = i;
                ans[1] = dic[target - nums[i]];
            }
            else if(!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i],i);
            }
        }
        return ans;
    }
}