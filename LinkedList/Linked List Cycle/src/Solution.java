public class Solution {
    public static boolean hasCycle(ListNode head) {
        ListNode slowPointer = head;
        if (slowPointer == null || slowPointer.next == null) {
            return false;
        }

        ListNode fastPointer = head.next;
        while (slowPointer != fastPointer) {
            if (fastPointer == null) {
                return false;
            } else {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next;
                if (fastPointer == null){
                    return false;
                }
                fastPointer = fastPointer.next;
            }
        }

        return true;
    }
}
