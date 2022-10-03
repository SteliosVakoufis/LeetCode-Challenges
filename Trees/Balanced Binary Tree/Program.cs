using Balanced_Binary_Tree;

var solver = new Solution();

//Case 1 start=n3
var n3 = new TreeNode(3);
var n9 = new TreeNode(9);
var n20 = new TreeNode(20);
var n15 = new TreeNode(15);
var n7 = new TreeNode(7);

n3.left = n9;
n3.right = n20;
n20.left = n15;
n20.right = n7;

System.Console.WriteLine($"Is balanced: {solver.IsBalanced(n3)}");