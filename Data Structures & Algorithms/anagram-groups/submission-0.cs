public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        //char[] letters = new char[26] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'}
        
        Dictionary<string,List<string>> sDict  = new Dictionary<string,List<string>>();
        foreach (string s in strs) {
            int[] letterCount = new int[26];
            foreach (char c in s) {
                letterCount[c - 97] += 1;
            }
            string key = string.Join(",", letterCount);
            if (!sDict.ContainsKey(key)) {
                sDict[key] = new List<string>();
            }
            sDict[key].Add(s);
        }
        return sDict.Values.ToList();
    }
}