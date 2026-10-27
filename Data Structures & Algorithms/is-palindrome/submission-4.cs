public class Solution {
    public bool IsPalindrome(string s) {
        string trimmedString = new string(
                                    s.Where(char.IsLetterOrDigit).
                                    Select(char.ToLowerInvariant).
                                    ToArray()
                                    );
        int middleIndex = trimmedString.Length / 2;


        if (string.IsNullOrEmpty(trimmedString)) {
            return true;
        }

        for (int i = 0; i < middleIndex ; i++) {
            if(trimmedString[i] != trimmedString[trimmedString.Length - i -1]){
                return false;
            }
        }
        return true;
    }
}
