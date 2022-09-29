class Solution {
    public static ListNode mergeTwoLists(ListNode list1, ListNode list2) {

        if (list1 == null && list2 == null)
            return null;
        if (list1 != null && list2 == null)
            return list1;
        if (list2 != null && list1 == null)
            return list2;

        ListNode current = null;
        if (list1 == null) {
            current = list2.next;
            list2 = list2.next;
        } else if (list2 == null) {
            current = list1.next;
            list1 = list1.next;
        } else {
            if (list1.val <= list2.val) {
                current = list1;
                list1 = list1.next;
            } else {
                current = list2;
                list2 = list2.next;
            }
        }

        ListNode head = current;

        while (true) {
            if (list1 == null && list2 == null) {
                return head;
            }
            if (list1 != null && list2 == null) {
                current.next = list1;
                current = list1;
                list1 = list1.next;
            } else if (list2 != null && list1 == null) {
                current.next = list2;
                current = list2;
                list2 = list2.next;
            } else {
                if (list1.val <= list2.val) {
                    current.next = list1;
                    current = list1;
                    list1 = list1.next;
                } else {
                    current.next = list2;
                    current = list2;
                    list2 = list2.next;
                }
            }
        }
    }
}
