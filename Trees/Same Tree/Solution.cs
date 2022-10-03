namespace Same_Tree
{
    public class Solution
    {
        public bool IsSameTree(TreeNode? p, TreeNode? q)
        {
            bool isSame = true;
            TraverseTree(q, p, ref isSame);
            return isSame;
        }

        private void TraverseTree(TreeNode? p, TreeNode? q, ref bool isSame)
        {
            if (p is null && q is null) return;
            if ((p is null && q is not null) || (q is null && p is not null) || p!.val != q!.val)
            {
                isSame = false;
                return;
            }

            TraverseTree(p.left, q.left, ref isSame);
            TraverseTree(p.right, q.right, ref isSame);

            return;
        }
    }
}
