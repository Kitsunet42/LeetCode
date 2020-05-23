public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var res = new List<IList<string>>();
        var dic = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            var c = strs[i].ToCharArray();
            Array.Sort(c);

            var s = new string(c);
            if (!dic.ContainsKey(s))
            {
                var list = new List<string>();
                list.Add(strs[i]);
                dic.Add(s,list);
            }
            else
            {
                dic[s].Add(strs[i]);
            }
        }

        foreach (var item in dic)
        {
            res.Add(item.Value);
        }

        return res;
    }
}