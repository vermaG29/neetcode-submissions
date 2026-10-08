public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> checksum = new Dictionary<int,int>();
        int diff =0;
        int i;
        for(i=0;i<nums.Length;i++)
        {
         diff = target - nums[i];
            if(checksum.ContainsKey(diff))
            {
                break;
            }
            else
            {
                checksum.Add(nums[i],i);
            }


        }

                 return new int[] {checksum[diff],i};



        }

    }

