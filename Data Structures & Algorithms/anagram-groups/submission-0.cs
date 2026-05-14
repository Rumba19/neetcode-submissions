public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
    var groups = new Dictionary<string, List<string>>();
    foreach(var word in strs){
        var key = string.Concat(word.Order());
       if(!groups.ContainsKey(key)){
        groups[key] = new List<string>();
       }
       
        groups[key].Add(word);

    }
       return groups.Values.ToList();;

    }
}
