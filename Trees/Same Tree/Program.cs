using Same_Tree;

var solver = new Solution();

// // Case 1
// var nA1 = new TreeNode(1);
// var nA2 = new TreeNode(2);

// var nB1 = new TreeNode(1);
// var nB2 = new TreeNode(2);

// nA1.left = nA2;
// nB1.right = nB2;

// System.Console.WriteLine($"Is same: {solver.IsSameTree(nA1, nB1)}");


// Case 2
var nA1 = new TreeNode(1);
var nA2 = new TreeNode(2);
var nA3 = new TreeNode(3);

var nB1 = new TreeNode(1);
var nB2 = new TreeNode(2);
var nB3 = new TreeNode(3);

nA1.left = nA2;
nA1.right = nA3;

nB1.left = nB2;
nB1.right = nB3;

System.Console.WriteLine($"Is same: {solver.IsSameTree(nA1, nB1)}");