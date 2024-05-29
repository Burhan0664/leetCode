public class Solution {
    public int StrStr(string haystack, string needle) {
      int result =-1;
        if (haystack.Contains(needle))
        {
            for (int i = 0; i < haystack.Length; i++)
        {
            for (int j = 0; j < needle.Length; j++)
            {
                if (haystack[i]==needle[0])
                {
                    if (result==-1)
                {
                   for (int a = 1; a <= needle.Length; a++)
                   {
                     if (needle[needle.Length-a]==haystack[i+needle.Length-a])
                     {
                        result=i;
                     }
                     else
                     {
                        result=-1;
                        break;
                     }
                      
                   }
                    
                    
                }
                    
                }
            }
        }  
        }
        
        return result;
    }
}