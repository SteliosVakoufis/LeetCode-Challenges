namespace Single_Number
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            
            int result = 0;

            foreach (var val in nums)
            {
                result = val ^ result;
            }

            return result;
        }
    }
}
