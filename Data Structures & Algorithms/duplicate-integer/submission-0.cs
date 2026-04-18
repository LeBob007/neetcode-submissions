public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> numList = new List<int>();

        for (int i = 0; i < nums.Length; i++ ){
            if (numList.Contains(nums[i])) {
                return true;
            }
            numList.Add(nums[i]);
        }

        return false;
    }
}