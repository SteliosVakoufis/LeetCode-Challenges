public class Solution {
    public static int maxDepth(TreeNode root) {
        return root != null ? maxDepthRecervise(root, 0, 0) : 0;
    }

    private static int maxDepthRecervise(TreeNode root, int count, int max) {
        TreeNode current = root;
        count += 1;
        if (current == null) {
            max = max < count ? count : max;
            return max;
        }
        
        if (current.left != null) {
            max = maxDepthRecervise(current.left, count, max);
        }
        if (current.right != null) {
            max = maxDepthRecervise(current.right, count, max);
        }

        max = max < count ? count : max;
        return max;
    }
}
