public class Solution {
    public bool IsValid(string s) {
 bool truth = true;
Stack<char> stack = new Stack<char>();

for (int i = 0; i < s.Length; i++)
{
    char c = s[i];

    if (c == '(' || c == '[' || c == '{')
    {
        stack.Push(c);
    }
    else if (c == ')' || c == ']' || c == '}')
    {
        if (stack.Count == 0)
        {
            truth = false;
            break;
        }

        char top = stack.Pop();

        if ((c == ')' && top != '(') ||
            (c == ']' && top != '[') ||
            (c == '}' && top != '{'))
        {
            truth = false;
            break;
        }
    }
}

if (stack.Count > 0)
{
    truth = false;
}

return truth;
    }
}