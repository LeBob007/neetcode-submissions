public class Solution {
    public bool IsPalindrome(string s) {
        if (s == "" || s == null) return true;
        int l = 0, r = s.Length - 1;

        while(l < r){
            while(l < r && !char.IsLetterOrDigit(s[l])) {
                l++;
            }
            while(r > l && !char.IsLetterOrDigit(s[r])) {
                r--;
            }
            if (char.ToLower(s[l]) != char.ToLower(s[r])) {
                return false;
            }
            (l, r) = (l+1, r-1);
        }
        return true;
    }
}
