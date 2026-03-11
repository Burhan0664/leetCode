using System.Runtime.InteropServices;

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        int result=n;
        while (result >= 2)
        {
            if (result % 2 == 0)
            {
                result = result / 2;
            }
            else
            {
                break;
            }

        }
        return result == 1 ? true : false;
    }
}