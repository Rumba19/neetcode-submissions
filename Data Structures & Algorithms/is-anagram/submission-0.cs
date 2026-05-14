public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
     
             // Count character frequency in s
        var counts = new Dictionary<char, int>();

        foreach (var c in s)
        {
            counts[c] = counts.GetValueOrDefault(c, 0) + 1;
        }
     // Subtract frequency using t
        foreach (var c in t)
        {
            if (!counts.ContainsKey(c)) return false; // char not in s at all
            counts[c]--;
            if (counts[c] < 0) return false; // t has more of this char than s
        }

        return true; // all counts balanced
    }
}
