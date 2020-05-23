public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var hset1 = new HashSet<int>(nums1);
        var hset2 = new HashSet<int>();
        for (int i = 0; i < nums2.Length; i++)
        {
            if (hset1.Contains(nums2[i]) && !hset2.Contains(nums2[i]))
            {
                hset2.Add(nums2[i]);
            }
        }

        int[] res = hset2.ToArray();
        return res;
    }
}