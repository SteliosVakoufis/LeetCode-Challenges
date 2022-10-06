using Subtree_of_Another_Tree;

internal class Program
{
    private static void Main(string[] args)
    {
        var solver = new Solution();
        
        // ROOT
        TreeNode nA3 = new(3);
        TreeNode nA4 = new(4);
        TreeNode nA5 = new(5);
        TreeNode nA1 = new(1);
        TreeNode nA2 = new(2);
        // TreeNode nA0 = new(0);
        // TreeNode nA9 = new(9);

        nA3.left = nA4;
        nA3.right = nA5;
        nA4.left = nA1;
        nA4.right = nA2;
        // nA2.left = nA0;
        // nA5.right = nA9;

        // subROOT
        TreeNode nB4 = new(4);
        TreeNode nB1 = new(1);
        TreeNode nB2 = new(2);
        // TreeNode nB0 = new(0);

        nB4.left = nB1;
        nB4.right = nB2;
        // nB2.left = nB0;

        System.Console.WriteLine(solver.IsSubtree(nA3, nB4));


        // // Case 2
        // TreeNode nA1 = new(1);
        // TreeNode nA2 = new(1);

        // nA1.left = nA2;

        // TreeNode nB1 = new(1);

        // PrintTree(nA1);
        // System.Console.WriteLine();
        // PrintTree(nB1);
        // System.Console.WriteLine();

        // System.Console.WriteLine(solver.IsSubtree(nA1, nB1));

        // // Case 3
        // TreeNode nA3 = new(3);
        // TreeNode nA4 = new(4);
        // TreeNode nA5 = new(5);
        // TreeNode nA1 = new(1);
        // TreeNode nA2 = new(2);

        // nA3.left = nA4;
        // nA3.right = nA5;
        // nA4.left = nA1;
        // nA4.right = nA2;

        // TreeNode nB4 = new(4);
        // TreeNode nB1 = new(1);
        // TreeNode nB2 = new(2);

        // nB4.left = nB1;
        // nB4.right = nB2;

        // PrintTree(nA3);
        // Console.WriteLine();

        // PrintTree(nB4);
        // Console.WriteLine();

        // System.Console.WriteLine(solver.IsSubtree(nA3, nB4));

        // Traverse();

        // // Case 4

        // TreeNode nA_1_1 = new(1);
        // TreeNode nA_1_2 = new(1);
        // nA_1_1.right = nA_1_2;

        // TreeNode nA_1_3 = new(1);
        // nA_1_2.right = nA_1_3;
        
        // TreeNode nA_1_4 = new(1);
        // nA_1_3.right = nA_1_4;
        
        // TreeNode nA_1_5 = new(1);
        // nA_1_4.right = nA_1_5;

        // TreeNode nA_1_6 = new(1);
        // nA_1_5.right = nA_1_6;

        // TreeNode nA_1_7 = new(1);
        // nA_1_6.right = nA_1_7;

        // TreeNode nA_1_8 = new(1);
        // nA_1_7.right = nA_1_8;

        // TreeNode nA_1_9 = new(1);
        // nA_1_8.right = nA_1_9;

        // TreeNode nA_1_10 = new(1);
        // nA_1_9.right = nA_1_10;

        // TreeNode nA_1_11 = new(1);
        // nA_1_10.right = nA_1_11;

        // TreeNode nA_1_12 = new(1);
        // nA_1_11.left = nA_1_12;


        // TreeNode nB_1_1 = new(1);
        // TreeNode nB_1_2 = new(1);
        // nB_1_1.right = nB_1_2;

        // TreeNode nB_1_3 = new(1);
        // nB_1_2.right = nB_1_3;
        
        // TreeNode nB_1_4 = new(1);
        // nB_1_3.right = nB_1_4;
        
        // TreeNode nB_1_5 = new(1);
        // nB_1_4.right = nB_1_5;

        // TreeNode nB_1_6 = new(1);
        // nB_1_5.right = nB_1_6;

        // TreeNode nB_1_7 = new(1);
        // nB_1_6.left = nB_1_7;

        // PrintTree(nA_1_1);
        // Console.WriteLine();

        // PrintTree(nB_1_1);
        // Console.WriteLine();

        // System.Console.WriteLine(solver.IsSubtree(nA_1_1, nB_1_1));
    }

    private static void PrintTree(TreeNode? node)
    {
        if (node is null)
            return;

        Console.Write($"{node.val} ");

        if (node.left is null)
        { System.Console.Write("- "); }
        else { PrintTree(node.left); }
        if (node.right is null)
        { System.Console.Write("+ "); }
        else { PrintTree(node.right); }

        return;
    }

    // private static void Traverse(int num = 0, bool traversing = false)
    // {
    //     if (num >= 10) return;
    //     if (num >= 5) traversing = true;
    //     Traverse(++num);
    //     System.Console.WriteLine($"Num: {num}, Traversing: {traversing}");
    // }
}