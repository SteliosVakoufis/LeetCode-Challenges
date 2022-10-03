using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diameter_of_Binary_Tree
{
    public class Solution
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            int result = 0;
            Dfs(root, ref result);
            return result;
        }

        private int Dfs(TreeNode node, ref int diameter)
        {
            if (node is null) return 0;

            int left = Dfs(node.left!, ref diameter);
            int right = Dfs(node.right!, ref diameter);
            diameter = Math.Max(diameter, left + right);

            return 1 + Math.Max(left, right);
        }
    }
}
