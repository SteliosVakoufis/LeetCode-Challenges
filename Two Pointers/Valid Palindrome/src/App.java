// A phrase is a palindrome if, after converting all uppercase letters into 
// lowercase letters and removing all non-alphanumeric characters, 
// it reads the same forward and backward. Alphanumeric characters include letters and numbers.

// Given a string s, return true if it is a palindrome, or false otherwise.

public class App {
    public static void main(String[] args) throws Exception {
        String s1 = "A man, a plan, a canal: Panama";
        String s2 = "race a car";
        String s3 = " ";

        System.out.println(Solution.isPalindrome(s1));
        System.out.println(Solution.isPalindrome(s2));
        System.out.println(Solution.isPalindrome(s3));
    }
}
