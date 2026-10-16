public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var anagramGroups = new Dictionary<string, List<string>>();

        foreach (var item in strs) {
            var freq = new int[26];
            foreach (var c in item) {
                freq[c - 'a']++;
            }
            var anagramCode = string.Join(',', freq);

            if (anagramGroups.TryGetValue(anagramCode, out List<string> group)) {
                group.Add(item);
            } else {
                anagramGroups.Add(anagramCode, new List<string> { item });
            }
        }
        return anagramGroups.Values.ToList();
    }
}
