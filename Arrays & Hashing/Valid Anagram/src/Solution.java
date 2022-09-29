import java.util.HashMap;
import java.util.Map;

// Faster solution would be to sort the arrays and then compare.
public class Solution {
    public static Map<Character, Integer> valuesToMap(String s){
        Map<Character, Integer> map = new HashMap<>();
        for (int i = 0; i < s.length(); i++){
            char c = s.charAt(i);
            if (map.containsKey(c)) map.put(c, map.get(c) + 1);
            else map.put(c, 1);
        }
        return map;
    }

    public static boolean isAnagram(String s, String t) {
        if (s.length() != t.length()) return false;

        Map<Character, Integer> sMap = valuesToMap(s);

        for (Character c : t.toCharArray()) {
            if (!sMap.containsKey(c)) return false;
            sMap.put(c, sMap.get(c) - 1);
            if (sMap.get(c) < 0) return false;
        }

        return true;
    }
}
