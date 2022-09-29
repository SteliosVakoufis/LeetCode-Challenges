import java.util.Arrays;

public class App {
    public static void main(String[] args) throws Exception {
        int[] nums1 = {2,7,11,15}; int target1 = 9;
        int[] nums2 = {3,2,4}; int target2 = 6;
        int[] nums3 = {3,3}; int target3 = 6;

        // assert Solution.twoSum(nums1, target1).equals(new int[]{2,7,11,15});
        // assert Solution.twoSum(nums2, target2).equals(new int[]{3,2,4});
        // assert Solution.twoSum(nums3, target3).equals(new int[]{3,3});

        System.out.println(Solution.twoSum(nums1, target1));
        System.out.println(Solution.twoSum(nums2, target2));
        System.out.println(Solution.twoSum(nums3, target3));

    }
}
