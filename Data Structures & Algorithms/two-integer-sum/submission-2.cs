public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var hashMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];

            if (hashMap.TryGetValue(diff, out int index)) {
                return [index, i];
            }
            hashMap.Add(nums[i], i);
        }
        return [];
    }
}
