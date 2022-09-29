import java.util.HashMap;
import java.util.Map;

class Solution {
    public static int[] twoSum(int[] nums, int target) {
        Map<Integer, Integer> map = new HashMap<>();

        for (int i = 0; i < nums.length; i++){
            int a = target - nums[i];
            if (map.containsKey(nums[i])){
                return new int[]{i, map.get(nums[i])};
            }
            map.put(a, i);
        }

        return new int[0];
    }
}
