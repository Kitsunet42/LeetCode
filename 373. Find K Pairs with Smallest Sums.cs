public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        
        var ans = new List<List<int>>();
        var res = new List<IList<int>>();
        
        for(int i = 0; i < nums1.Length; ++i) {
            for(int j = 0; j < nums2.Length; ++j) {                
                ans.Add(new List<int>{nums1[i], nums2[j]});
            }
        }
        
        ans.Sort((x, y) => (x[0] + x[1]) - (y[0] + y[1]));
        
        for(int i = 0; i < Math.Min(k, ans.Count); ++i) {
            res.Add(ans[i]);
        }
        
        return res;
    }
}