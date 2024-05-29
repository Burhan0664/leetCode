public class Solution {
    public int ClimbStairs(int n) {
  int a = 0;
			int b = 1;
			int c = 1;
			
				for (int i = 0; i < n; i++)
				{
					c=b;
					b=b+a;
					a=c;
				}
				return b;

			
		
		}
}