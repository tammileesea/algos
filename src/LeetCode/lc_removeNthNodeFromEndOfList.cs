//REMOVE NTH NODE FROM END OF LIST

// Given the head of a linked list, 
// remove the nth node from the end of the list and return its head.


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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int nodeCount = 0;
        ListNode current = head;

        while (current.next != null)
        {
            nodeCount++;
            current = current.next;
        }

        nodeCount++;

        if (nodeCount < 2)
        {
            return null;
        }

        int target = nodeCount - n;
        int targetCount = 0;

        current = head;

        while (current.next != null)
        {
            if (target == 0)
            {
                current = current.next;
                return current;
            }
            else if (targetCount == target - 1)
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
}