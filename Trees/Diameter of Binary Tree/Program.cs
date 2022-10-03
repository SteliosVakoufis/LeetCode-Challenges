using Diameter_of_Binary_Tree;

var tester = new Solution();

//Case 1 start=n1
var n1 = new TreeNode(1);
var n2 = new TreeNode(2);
var n3 = new TreeNode(3);
var n4 = new TreeNode(4);
var n5 = new TreeNode(5);
n1.left = n2;
n1.right = n3;
n2.left = n4;
n2.right = n5;
System.Console.WriteLine($"Case1\nDiameter: {tester.DiameterOfBinaryTree(n1)}");

// //Case 2 start=n3
// var n3 = new TreeNode(3);
// var n1 = new TreeNode(1);
// var n2 = new TreeNode(2);
// n3.left = n1;
// n1.right = n2;
// System.Console.WriteLine($"Case2\nDiameter: {tester.DiameterOfBinaryTree(n3)}");

// //Case 3 start=n3
// var n3 = new TreeNode(3);
// var n1 = new TreeNode(1);
// var n2 = new TreeNode(2);
// n3.right = n1;
// n1.left = n2;
// System.Console.WriteLine($"Case3\nDiameter: {tester.DiameterOfBinaryTree(n3)}");

// //Case 4 start=n4
// var n4 = new TreeNode(4);
// var n2 = new TreeNode(2);
// var n1 = new TreeNode(1);
// var n3 = new TreeNode(3);
// n4.left = n2;
// n2.left = n1;
// n2.right = n3;
// System.Console.WriteLine($"Case4\nDiameter: {tester.DiameterOfBinaryTree(n4)}");