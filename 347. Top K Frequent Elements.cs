public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i], 1);
            }
            else
            {
                dic[nums[i]]++;
            }
        }

        int[] ans = new int[k];
        var t = 0;
        foreach(var item in dic.OrderByDescending(x => x.Value))
        {
            if (t < k)
            {
                ans[t] = item.Key;
                t++;
            }
        }
        return ans;
    }
}