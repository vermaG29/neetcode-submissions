public class Solution {
    public bool hasDuplicate(int[] nums) {
       bool flag = false;
      HashSet<int> checkdupe = new HashSet<int>();
      foreach(int i in nums)
      {
        if(checkdupe.Contains(i))
        {
            flag = true;
            break;
        }
        else
        {
            checkdupe.Add(i);
        }
    
        
      }

return flag;        
    }
}