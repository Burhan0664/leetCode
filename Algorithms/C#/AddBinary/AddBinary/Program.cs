public class Solution
{
    public string AddBinary(string a, string b)
    {
        int j = a.Length - 1;
        int k = b.Length - 1;
        int carry = 0;
        string result = "";
       

        while(j >= 0 || k >= 0 || carry == 1) 
        {
            int sum = carry;
            if(j >= 0)
            {
                sum += a[j--] - '0';           
            }

            if (k >= 0)
            {
                sum += b[k--] - '0';
            }

            result = (sum % 2) + result;
            carry = sum / 2;
        }
        
        return result;
    }
}
