public class Solution {
    public int MySqrt(int x) 
    {
        if (x == 0 || x == 1) return x;

        int start = 1, end = x / 2, ans = 0;

        while(start <= end)
        {
            int mid = (start + end) / 2;

            if (mid * mid == x)
                return mid;
            if(Math.Floor((double)mid * (double)mid) < x)
            {
                start = mid + 1;
                ans = mid;
            }
            else
            {
                end = mid - 1;
            }
        }
            return ans;
    }
}