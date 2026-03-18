public class Solution
{
    public int HammingWeight(int n)
    {
        string number = Convert.ToString(n,2);
        int result = 0;
        foreach(int i in number)
        {
            if(i == '1') 
            {
               result++;
            }
            
        }
        return result;
    }
}