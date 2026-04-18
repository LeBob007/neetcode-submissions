public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> sDict = new Dictionary<char, int>();
        Dictionary<char, int> tDict = new Dictionary<char, int>();
        foreach (char c in s) {
            if (sDict.ContainsKey(c)) {
                sDict[c] += 1;
            }
            else {
                sDict[c] = 1;
            }
        }

        foreach (char c in t) {
            if (tDict.ContainsKey(c)) {
                tDict[c] += 1;
            }
            else {
                tDict[c] = 1;
            }
        }

        foreach (var (key, value) in sDict) {
            if (!tDict.ContainsKey(key) || (tDict.ContainsKey(key) && tDict[key] != value)) {
                return false;
            } 
        }
        return true;
    }
}
