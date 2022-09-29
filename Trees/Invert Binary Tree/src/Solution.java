class Solution {
    public static TreeNode invertTree(TreeNode root) {
        if (root == null)
            return null;
        else {
            invertBinaryTree(root);
            return root;
        }
    }

    private static TreeNode invertBinaryTree(TreeNode root) {
        if (root.left != null) {
            invertBinaryTree(root.left);
        }
        if (root.right != null) {
            invertBinaryTree(root.right);
        }
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;

        return root;
    }
}
