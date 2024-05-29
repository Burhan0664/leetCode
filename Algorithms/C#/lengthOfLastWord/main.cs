public class Solution {
    public int LengthOfLastWord(string s) {
          int result =0;
            for (int i = 0; i < s.Length-1; i++)
            {
                if (s[i]!=' ')
                {
                    result++;
                }
                else if (s[i]==' '&&s[i+1]!=' ')
                {
                    result=0;
                }
                

            }
            if(s[s.Length-1]!=' '){
                result++;
            }
            return result;

    }
}