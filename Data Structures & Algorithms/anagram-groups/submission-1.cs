public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();
        foreach (var str in strs) {
            int[] freq = new int[26];
            foreach (var c in str) {
                freq[c - 'a']++;
            }
            string key = string.Join(',', freq);

            if (groups.TryGetValue(key, out List<string> list)) {
                list.Add(str);
            } else {
                groups.Add(key, new List<string> { str });
            }
        }

        return groups.Values.ToList();
    }
}
