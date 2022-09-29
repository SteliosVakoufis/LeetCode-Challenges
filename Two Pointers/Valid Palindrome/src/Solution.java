class Solution {
    public static boolean isPalindrome(String s) {
        int low = 0, high = s.length() - 1;

        while (low < high){
            if (Character.isLetterOrDigit(s.charAt(low))){
                if (Character.isLetterOrDigit(s.charAt(high))){
                    if (Character.toLowerCase(s.charAt(low)) != 
                        Character.toLowerCase(s.charAt(high))) 
                        return false;
                    low++;
                    high--;
                }else{
                    high--;
                }
            }else{
                low++;
            }
        }

        return true;
    }
}
