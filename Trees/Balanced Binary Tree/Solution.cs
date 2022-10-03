namespace Balanced_Binary_Tree
{
    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            int result = 0;
            MaxDepth(root, ref result);
            System.Console.WriteLine(result);
            return result <= 1 ? true : false;
        }

        private int MaxDepth(TreeNode? node, ref int mHeight)
        {
            if (node is null) return 0;

            int lHeight = MaxDepth(node.left, ref mHeight);
            int rHeight = MaxDepth(node.right, ref mHeight);
            mHeight = Math.Max(mHeight, Math.Abs(lHeight - rHeight));

            return 1 + Math.Max(lHeight, rHeight);
        }
    }
}
