public class Solution
{
    public int RomanToInt(string s)
    {
        int result = 0;
        char x,y;
        int negative = 0;
        var liste = new List<(char Key, int Value)>
        {
            ('I',1),
            ('V',5),
            ('X',10),
            ('L',50),
            ('C',100),
            ('D',500),
            ('M',1000)
        };

        foreach (var c in s)
        {
            foreach (var e in liste)
            {
                if (e.Key == c)
                {
                    result += e.Value;
                    break;
                }
                
            }
        }
        for (int a = 0; a < s.Length; a++)
        {
            if (s[a] == 'I')
            {
                for (int i = a; i < a+2; i++)
                {
                    if (s[i] == 'V' || s[i] == 'X')
                    {
                        negative += 2;
                    }
                }
            }
            if (s[a] == 'X')
            {
                for (int i = a; i < a + 2; i++)
                {
                    if (s[i] == 'L' || s[i] == 'C')
                    {
                        negative += 20;
                    }
                }
            }
            if (s[a] == 'C')
            {
                for (int i = a; i < a + 2; i++)
                {
                    if (s[i] == 'D' || s[i] == 'M')
                    {
                        negative += 200;
                    }
                }
            }
        }
 


        return result-negative;
    }
}