//REVERSE SINGLY LINKED LIST

public class ReverseListSolution {
    //ITERATIVE SOLUTION
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode current = head;
        ListNode next = null;

        while (current != null)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }

    //RECURSIVE SOLUTION
    
}