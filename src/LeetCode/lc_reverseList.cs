//REVERSE SINGLY LINKED LIST

public class ReverseListSolution {
    //ITERATIVE SOLUTION
    public ListNode ReverseListIteratively(ListNode head) {
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

    //RECURSIVE SOLUTIONS
    public ListNode ReverseListRecursively_1(ListNode head) 
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        ListNode reversed = ReverseListRecursively_1(head.next); 
        head.next.next = head; //
        head.next = null;

        return reversed;
    }


    public ListNode ReverseListRecursively_2(ListNode head, ListNode prev) 
    {
        if (head == null)
        {
            return prev;
        }

        ListNode next = head.next;
        head.next = prev;

        return ReverseListRecursively_2(next, head);
    }
}

// NOTES
// the 2nd recursive one is like a direct translation of the iterative approach
// I think i FINALLY realized what I'd been missing in terms of my failure of TRUE recursion understanding
// for whatever reason, I failed to truly understand how stacks work in recursion. NOW I GET IT 
// tg for youtube!!!