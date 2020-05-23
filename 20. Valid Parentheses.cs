public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Count == 0) return false;
                var t = stack.Pop();
                switch (t)
                {
                    case '(':
                        if (s[i] != ')') return false;
                        break;
                    case '[':
                        if (s[i] != ']') return false;
                        break;
                    case '{':
                        if (s[i] != '}') return false;
                        break;
                }
            }
        }
        if (stack.Count > 0) return false;
        return true;
    }
}