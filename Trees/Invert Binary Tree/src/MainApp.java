public class MainApp {
    public static void main(String[] args) {
        TreeNode node1 = new TreeNode(4);
        TreeNode node2 = new TreeNode(2);
        TreeNode node3 = new TreeNode(7);
        TreeNode node4 = new TreeNode(1);
        TreeNode node5 = new TreeNode(3);
        TreeNode node6 = new TreeNode(6);
        TreeNode node7 = new TreeNode(9);

        node1.left = node2;
        node1.right = node3;
        node2.left = node4;
        node2.right = node5;
        node3.left = node6;
        node3.right = node7;

        printTree(node1);
        Solution.invertTree(node1);
        printTree(node1);

    }

    private static void printTree(TreeNode root) {
        printBinaryTree(root);
        System.out.println();
    }

    private static TreeNode printBinaryTree(TreeNode node) {
        System.out.printf("%d ", node.val);
        if (node.left != null) {
            printBinaryTree(node.left);
        }
        if (node.right != null) {
            printBinaryTree(node.right);
        }

        return node;
    }
}
