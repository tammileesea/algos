//REMOVE NTH NODE FROM END OF LIST

// Given the head of a linked list, 
// remove the nth node from the end of the list and return its head.

// Input: head = [1,2,3,4,5], n = 2
// Output: [1,2,3,5]

// Input: head = [1], n = 1
// Output: []

// Input: head = [1,2], n = 1
// Output: [1]


//  Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode (int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}

public class RemoveNthNodeSolution {
    // MY SOLUTION
    // Runtime: 82ms
    // Memory: 39MB
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        //if there is only 1 node, return null
        if (head.next == null)
        {
            return null;
        }

        int nodeCount = 0;
        ListNode current = head;

        while (current != null)
        {
            nodeCount++;
            current = current.next;
        }

        //if the number of nodes and n are the same, that means the first node must be removed
        if (nodeCount == n)
        {
            head = head.next;
            return head;
        }

        int target = nodeCount - n;
        int targetCount = 0;

        current = head;

        while (targetCount < target)
        {
            if (targetCount == target - 1)
            {
                current.next = current.next.next;
                break;
            }
            else
            {
                targetCount++;
                current = current.next;
            }
        }

        return head;
    }


    // OTHER SOLUTION
    public ListNode removeNthFromEnd(ListNode head, int n) 
    {
        ListNode fast = head;
        ListNode slow = head;

        for (int i = 0; i < n; i++) 
        {
            fast = fast.next;
        }

        //so if there are only 2 nodes, it'll just return the 2nd one
        if (fast == null) return head.next;

        //by this point, fast is always n # of nodes ahead of slow
        while (fast.next != null) {
            fast = fast.next;
            slow = slow.next;
        }

        slow.next = slow.next.next;
        return head;
    }
}