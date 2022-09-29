import java.util.Map;
import java.util.Stack;

class Solution {
    private final static Map<Character, Character> parentheses = Map.of(
        '(', ')',
        '[', ']',
        '{', '}'
    );

    public static boolean isValid(String s) {
        if (s.length() <= 1 ) return false;

        Stack<Character> stack = new Stack<>();

        for (Character ch : s.toCharArray()) {
            if (ch == ')' || ch == ']' || ch == '}'){
                if (stack.size() == 0) return false;
                if (parentheses.get(stack.pop()) != ch) return false;
            }else{
                stack.push(ch);
            }

        }

        return stack.size() == 0 ? true : false;
    }
}
