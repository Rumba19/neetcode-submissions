public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hashSet = new HashSet<int>(nums);
        bool isSet = nums.Length == hashSet.Count;
       if(isSet){
        return false;
       }
       return true;
    }
}