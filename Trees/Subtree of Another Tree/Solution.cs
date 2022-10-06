using System.Collections;

namespace Subtree_of_Another_Tree
{
    public class Solution
    {
        public bool IsSubtree(TreeNode? root, TreeNode? subRoot)
        {
            var rootList = new List<int?>();
            var subRootList = new List<int?>();

            TraverseTree(root, ref rootList);
            TraverseTree(subRoot, ref subRootList);

            rootList.ForEach(val => System.Console.Write(val is null ? "null " : val + " "));
            System.Console.WriteLine();
            subRootList.ForEach(val => System.Console.Write(val is null ? "null " : val + " "));
            System.Console.WriteLine();

            // System.Console.WriteLine(ListContains(rootList, subRootList));

            return ListContains(rootList, subRootList);
        }

        private void TraverseTree(TreeNode? node, ref List<int?> list)
        {
            if (node is null) return;

            list.Add(node.val);

            if (node.left is null) { list.Add(null); }
            else { this.TraverseTree(node.left, ref list); }
            if (node.right is null) { list.Add(null); }
            else { this.TraverseTree(node.right, ref list); }

            return;
        }

        private bool ListContains(List<int?> a, List<int?> b)
        {
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < b.Count; j++)
                {
                    // System.Console.WriteLine($"{i + j}({a[i + j]}) {j}({b[j]})");
                    if (!a[i + j].Equals(b[j])) break;
                    if (j == b.Count - 1) return true;
                }
            }

            return false;
        }

        // private bool ListContains(List<int?> a, List<int?> b)
        // {
        //     for (int i = 0, j = 0; i < a.Count; i++)
        //     {
        //         int remainA = (a.Count - 1) - i;
        //         int remainB = (b.Count - 1) - j;
        //         if (a[i] == b[j] && remainA >= remainB)
        //         {
        //             if (j == b.Count - 1)
        //                 return true;
        //             j++;
        //         }
        //         else
        //         {
        //             j = 0;
        //             if (a[i] == b[j] && remainA >= remainB)
        //             {
        //                 j++;
        //             }
        //         }
        //     }

        //     return false;
        // }
    }
}