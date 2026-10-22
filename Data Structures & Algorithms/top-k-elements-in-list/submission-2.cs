public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var groups = new Dictionary<int, int>();

        foreach (var num in nums) {
            if (groups.TryGetValue(num, out int value))
                groups[num] = value + 1;
            else
                groups.Add(num, 1);
        }

        List<int>[] bucket = new List<int>[nums.Length + 1];
        foreach (var group in groups) {
            if (bucket[group.Value] == null) {
                bucket[group.Value] = new List<int>();
            }
            bucket[group.Value].Add(group.Key);
        }

        var result = new int[k];
        int index = 0;
        for (int i = bucket.Length - 1; i > 0 && index < k; i--) {
            if (bucket[i] != null) {
                foreach (var num in bucket[i]) {
                    result[index++] = num;
                    if (index == k) {
                        return result;
                    }
                }
            }
        }
        return result;
    }
}
