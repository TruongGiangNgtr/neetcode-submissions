public class Solution {
    public bool IsAnagram(string s, string t) {
        var freq = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            freq[s[i]] = freq.GetValueOrDefault(s[i], 0) + 1;
        }

        for (int i = 0; i < t.Length; i++) {
            if (!freq.ContainsKey(t[i])) {
                return false;
            } else {
                freq[t[i]]--;
            }
        }

        if (freq.All(x => x.Value == 0)) {
            return true;
        }

        return false;
    }
}
