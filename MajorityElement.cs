public class Solution {
    
    public  int MajorityElement(int[] nums)
     {
        
     Dictionary<int , int> myDictionary = new Dictionary<int, int> ();
     
     int count = 0;
     int majority = nums.Length / 2;

     foreach ( var num in nums)
     {
        if( !myDictionary.ContainsKey(num))
        {
            myDictionary[num] = 1;
        }
        else
        {
            myDictionary[num]++;
        }
     

        if( myDictionary[num] > majority)
       {
         return num;
       }

     }

     return -1;
    }
  //solution 1
    //     int number = (nums.Length /2);
    //     int majorityElement = 0;
    //     for (int i = 0 ; i < nums.Length - 1 ; i++)
    //     {
    //          int counter = 1;
    //         for (int j = i + 1 ; j < nums.Length ; j++)
    //         {
    //            if ( nums[i] == nums[j])
    //           {
    //              counter++;
    //           }
    //         }
    //         if ( counter > number)
    //         {
    //             majorityElement = nums[i]; 
    //         }
    //     }
    //     return majorityElement; 
    
    // solution2
        // Array.Sort(nums);
        // return nums[nums.Length / 2];


 }
