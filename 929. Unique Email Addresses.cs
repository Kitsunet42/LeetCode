public class Solution
{
    public int NumUniqueEmails(string[] emails)
    {
        var hset = new HashSet<string>();
        for (int i = 0; i < emails.Length; i++)
        {
            string[] tmp = emails[i].Split("@");

            StringBuilder sb = new StringBuilder("");
            for (int k = 0; k < tmp[0].Length; k++)
            {
                if (tmp[0][k] == '+') break;
                if (tmp[0][k] != '.') sb.Append(tmp[0][k].ToString());
            }
            var localname = sb.ToString();

            var domainname = tmp[1];

            if (!hset.Contains(localname + "@" + domainname))
            {
                hset.Add(localname + "@" +domainname);
            }
        }

        var ans = hset.Count();
        return ans;
    }
}