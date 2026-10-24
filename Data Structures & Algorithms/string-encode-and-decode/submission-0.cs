public class Solution {
    public string Encode(IList<string> strs) {
        return string.Concat(strs.Select(x => $"{x.Length}#{x}"));
    }

    public List<string> Decode(string s) {
        char[] str = s.ToArray();
        var decodedString = new List<string>();

        for (int i = 0; i < str.Length; i++) {
            for (int j = i + 1; j < str.Length; j++) {
                if (str[j] == '#') {
                    int length = int.Parse(s.Substring(i, j - i));
                    decodedString.Add(s.Substring(j + 1, length));
                    j = j + length;
                    if (j == str.Length) {
                        return decodedString;
                    } else {
                        i = j + 1;
                    }
                }
            }
        }
        return decodedString;
    }
}
