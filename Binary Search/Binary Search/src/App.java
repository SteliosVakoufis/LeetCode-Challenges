public class App {
    public static void main(String[] args) throws Exception {
        int[] nums1 = { -1, 0, 3, 5, 9, 12 }; // Target = 9 | Output = 4
        int[] nums2 = { -1, 0, 3, 5, 9, 12 }; // Target = 2 | Output = -1
        int[] nums3 = { 5 }; // Target = 5 | Output = 0
        int[] nums4 = { 2, 5 }; // Target = 5 | Output = 1

        System.out.println(Solution.search(nums1, 9));
        System.out.println(Solution.search(nums2, 2));
        System.out.println(Solution.search(nums3, 5));
        System.out.println(Solution.search(nums4, 5));

    }
}
