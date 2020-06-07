public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        var res = 0;
        var list = wordList.ToList();
        if (!list.Contains(endWord)) return res;

        var que1 = new Queue<string>();
        var que2 = new Queue<int>();
        que1.Enqueue(beginWord);
        que2.Enqueue(1);

        while (que1.Count > 0)
        {
            var s = que1.Dequeue();
            var n = que2.Dequeue();
            if (s == endWord)
            {
                res = n;
                break;
            }

            var rem = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                var tmp = list[i];
                var count = 0;

                for (int k = 0; k < beginWord.Length; k++)
                {
                    if (s[k] != tmp[k]) count++;
                    if (count > 2) break;
                }

                if (count == 1)
                {
                    que1.Enqueue(tmp);
                    que2.Enqueue(n + 1);
                    rem.Add(tmp);
                }
            }

            for (int k = 0; k < rem.Count; k++)
            {
                list.Remove(rem[k]);
            }
        }

        return res;
    }
}