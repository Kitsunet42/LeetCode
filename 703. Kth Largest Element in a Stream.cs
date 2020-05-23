public class KthLargest
{
    private int k;
    private int size;
    private SortedDictionary<int, int> sdic;

    public KthLargest(int k, int[] nums)
    {
        this.k = k;
        size = 0;
        sdic = new SortedDictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!sdic.ContainsKey(nums[i]))
            {
                sdic.Add(nums[i], 1);
            }
            else
            {
                sdic[nums[i]]++;
            }
            size++;
        }

        while (k < size)
        {
            if (sdic.First().Value == 1)
            {
                sdic.Remove(sdic.First().Key);
                size--;
            }
            else
            {
                sdic[sdic.First().Key]--;
                size--;
            }
        }
    }

    public int Add(int val)
    {
        size++;
        if (!sdic.ContainsKey(val))
        {
            sdic.Add(val, 1);
        }
        else
        {
            sdic[val]++;
        }

        while (k < size)
        {
            if (sdic.First().Value == 1)
            {
                sdic.Remove(sdic.First().Key);
                size--;
            }
            else
            {
                sdic[sdic.First().Key]--;
                size--;
            }
        }

        var ans = sdic.First().Key;
        return ans;
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
