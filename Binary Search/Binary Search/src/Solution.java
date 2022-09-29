class Solution {
    public static int search(int[] nums, int target) {
        int low = 0;
        int high = nums.length - 1;

        int mid;

        do {
            mid = (low + high) / 2;

            if (target == nums[mid]) {
                return mid;
            }
            if (target > nums[mid]) {
                low = mid + 1;
            } else if (target < nums[mid]) {
                high = mid - 1;
            }

        } while (low <= high);

        return -1;
    }
}
