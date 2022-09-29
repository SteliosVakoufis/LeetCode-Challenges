// Given an integer array nums, return true if any value appears 
// at least twice in the array, and return false if every element is distinct.

public class App {
    public static void main(String[] args) throws Exception {
        int[] arr1 = {1,2,3,1}; // Should return true
        int[] arr2 = {1,2,3,4}; // Should return false
        int[] arr3 = {1,1,1,3,3,4,3,2,4,2}; // Should return true

        System.out.println(Solution.containsDuplicate(arr1));
        System.out.println(Solution.containsDuplicate(arr2));
        System.out.println(Solution.containsDuplicate(arr3));

        System.out.println();
    }
}
