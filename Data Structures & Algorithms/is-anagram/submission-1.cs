public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] arr1 = s.ToArray();
        Array.Sort(arr1);

        char[] arr2 = t.ToArray();
        Array.Sort(arr2);

        return arr1.SequenceEqual(arr2);
    }
}
