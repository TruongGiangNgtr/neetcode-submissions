public class Solution {
    public bool hasDuplicate(int[] nums) {
        var seen = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            if (seen.TryGetValue(nums[i], out int value)) {
                return true;
            } else {
                seen.Add(nums[i], 1);
            }
        }
        return false;
    }
}