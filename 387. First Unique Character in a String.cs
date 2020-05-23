public class Solution
{
    public int FirstUniqChar(string s)
    {
        var res = int.MaxValue;
        var count = new Dictionary<char, int>();
        var index = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!count.ContainsKey(s[i]))
            {
                count.Add(s[i], 1);
                index.Add(s[i],i);
            }
            else
            {
                count[s[i]]++;
            }
        }

        foreach(var item in count)
        {
            if (item.Value == 1)
            {
                res = Math.Min(res , index[item.Key]);
            }
        }

        if (res == int.MaxValue) res = -1;

        return res;
    }
}