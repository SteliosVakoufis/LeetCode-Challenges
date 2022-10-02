public class App {
    public static void main(String[] args) throws Exception {
        var node1 = new TreeNode(3);
        var node2 = new TreeNode(9);
        var node3 = new TreeNode(20);
        var node4 = new TreeNode(15);
        var node5 = new TreeNode(7);

        node1.left = node2;
        node1.right = node3;

        node3.left = node4;
        node3.right = node5;

        // printTree(node1);
        System.out.println(Solution.maxDepth(node1));
    }

    private static TreeNode printTree(TreeNode node) {
        TreeNode current = node;
        if (current == null) {
            return current;
        }

        System.out.printf("%d ", current.val);
        if (current.left != null) {
            printTree(current.left);
        }
        if (current.right != null) {
            printTree(current.right);
        }

        return current;
    }
}
