public class MainApp {
    public static void main(String[] args) {
        ListNode nodea1 = new ListNode(1);
        ListNode nodea2 = new ListNode(2);
        ListNode nodea3 = new ListNode(4);
        ListNode nodea4 = new ListNode(7);
        ListNode nodea5 = new ListNode(8);

        nodea1.next = nodea2;
        nodea2.next = nodea3;
        nodea3.next = nodea4;
        nodea4.next = nodea5;

        printLinkedList(nodea1);

        ListNode nodeb1 = new ListNode(-3);
        ListNode nodeb2 = new ListNode(-1);
        ListNode nodeb3 = new ListNode(2);
        ListNode nodeb4 = new ListNode(4);
        ListNode nodeb5 = new ListNode(6);

        nodeb1.next = nodeb2;
        nodeb2.next = nodeb3;
        nodeb3.next = nodeb4;
        nodeb4.next = nodeb5;

        printLinkedList(nodeb1);

        printLinkedList(Solution.mergeTwoLists(nodea1, nodeb1));
    }

    private static void printLinkedList(ListNode current) {
        System.out.println();
        while (current != null) {
            System.out.printf("%d %s ", current.val, current.next != null ? "->" : "");
            current = current.next;
        }
        System.out.println();
    }
}
