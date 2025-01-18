public class Solution
{

 public int[] TwoSum(int[] nums, int target) {
         int[] TwoSumArr = new int [2];

        for (int i = 0 ; i< nums.Length - 1 ; i++)
        {
            for ( int j = 1 + i ; j< nums.Length ; j++ )
            {
                if ( nums[i] + nums[j] == target)
                {

                    return new int[] {i, j};

                }
            }
       
        }
            return new int[0] {};
        
    }
}
