public class Solution {
        public bool IsPalindrome(int x) {
              string number = "";

    for (int i = 0; i < x.ToString().Length; i++)
    {
        number += x.ToString()[x.ToString().Length - i-1 ];
    }

    if (number == x.ToString())
    {
        return true;
    }
    else
    {
        return false;
    }
            }
        }
    