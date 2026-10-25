public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var groups = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            groups[nums[i]] = groups.GetValueOrDefault(nums[i], 0) + 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];  // index = freq.value
        foreach (var group in groups) {
            if (buckets[group.Value] == null) {
                buckets[group.Value] = new List<int>();
            }
            buckets[group.Value].Add(group.Key);
        }

        int index = 0;
        var result = new int[k];
        for (int i = buckets.Length - 1; i > 0 && index < k; i--) {
            if (buckets[i] != null) {
                foreach (var num in buckets[i]) {
                    result[index++] = num;
                }
            }
        }
        return result;
    }
}
