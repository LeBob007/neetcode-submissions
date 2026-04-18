public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> numsDict = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++) {
            int temp = target - nums[i];
            if (numsDict.ContainsKey(temp)) {
                return [numsDict[temp], i];
            } else {
                numsDict[nums[i]] = i;
            }
        }

        return null;
    }
}
