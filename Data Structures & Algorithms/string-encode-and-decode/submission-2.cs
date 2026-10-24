public class Solution {
    public string Encode(IList<string> strs) {
        var encodeString = new System.Text.StringBuilder();
        foreach (var str in strs) {
            encodeString.Append(str.Length).Append('#').Append(str);
        }
        return encodeString.ToString();
    }

    public List<string> Decode(string s) {
        var decodedString = new List<string>();
        int i = 0;

        while (i < s.Length) {
            var index = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, index - i));
            decodedString.Add(s.Substring(index + 1, length));
            i = index + length + 1;
        }
        return decodedString;
    }
}
