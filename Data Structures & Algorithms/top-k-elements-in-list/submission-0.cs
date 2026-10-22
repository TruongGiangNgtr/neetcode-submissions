public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var groups = new Dictionary<int, int>();
        foreach (var num in nums) {
            if (groups.TryGetValue(num, out int value)) {
                groups[num] = ++value;
            } else {
                groups.Add(num, 1);
            }
        }
        int[] result = groups.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
        return result;
    }
}
