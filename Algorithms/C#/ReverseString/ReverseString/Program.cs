public class Solution
{
    public void ReverseString(char[] s)
    {
        int lengthOfLast = s.Length - 1;
        char hold;
        for (int i = 0; i < s.Length/2; i++)
        {
            hold = s[lengthOfLast];
            s[lengthOfLast] = s[i];
            s[i] = hold;
            lengthOfLast--;
        }
        Console.WriteLine(s);
    }

        public void ReverseString2(char[] s)
        {

            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                char temp = s[i];
                s[i] = s[j];
                s[j] = temp;

                i++;
                j--;
            }
        }
    }
