// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', 
// determine if the input string is valid.

// An input string is valid if:

// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// Every close bracket has a corresponding open bracket of the same type.

public class App {
    public static void main(String[] args) throws Exception {
        String s1 = "()"; // true
        String s2 = "()[]{}"; // true
        String s3 = "(]"; // false
        String s4 = "([)]"; // false
        String s5 = "(("; // false

        System.out.println(Solution.isValid(s1));
        System.out.println(Solution.isValid(s2));
        System.out.println(Solution.isValid(s3));
        System.out.println(Solution.isValid(s4));
        System.out.println(Solution.isValid(s5));
    }
}
