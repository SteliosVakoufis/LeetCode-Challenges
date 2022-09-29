import java.util.HashMap;
import java.util.Map;

public class Solution {
    public static boolean containsDuplicate(int[] nums) {
        Map<Integer, Integer> values = new HashMap<>();

        for (int i : nums) {
            if (!values.containsKey(i)) values.put(i, 1);
            else return true;
        }

        return false;
    }
}
