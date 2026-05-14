public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        var counts = new Dictionary<int, int>();
        foreach (var n in nums)
         counts[n] = counts.GetValueOrDefault(n, 0) + 1;
        
         return counts
        .OrderByDescending(pair => pair.Value)  // sort by count descending
        .Take(k)                                 // take first k pairs
        .Select(pair => pair.Key)               // extract just the number
        .ToArray();
    }
}
