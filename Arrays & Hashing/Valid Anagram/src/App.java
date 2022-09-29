// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
// An Anagram is a word or phrase formed by rearranging the letters of 
// a different word or phrase, typically using all the original letters exactly once.

public class App {
    public static void main(String[] args) throws Exception {
        String s1 = "anagram", t1 = "nagaram";
        String s2 = "rat", t2 = "car";
        System.out.println(Solution.isAnagram(s1, t1));
        System.out.println(Solution.isAnagram(s2, t2));
    }
}
