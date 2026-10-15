public class Solution {
    public bool hasDuplicate(int[] nums) {
        int countLoop = 0;
        if (nums.Length == 0)
        {
            return false;
        }
        for (int i = 0; i <= nums.Length; i++)
        {
            
            if (countLoop == nums.Length)
            {
                if (nums[i] == nums.Last());
                {
                    return true;
                }
            }
            else
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    

                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
            
        }
        return false;

    }
}