public class App {
    public static void main(String[] args) throws Exception {
        var node1 = new ListNode(3);
        var node2 = new ListNode(2);
        var node3 = new ListNode(0);
        var node4 = new ListNode(4);
        
        // node1.next = node1;
        
        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node2;

        System.out.printf("Is cyclic: %b\n", Solution.hasCycle(node1));
    }

    private static void printNodes(ListNode node) {
        ListNode current = node;

        while (current != null) {
            System.out.printf("%d %s ",
                    current.val,
                    current.next != null ? "->" : "");
            current = current.next;
        }
        System.out.println();
    }
}
