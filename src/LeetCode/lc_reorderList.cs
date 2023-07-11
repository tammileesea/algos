// REORDER LIST (SSL)
// You are given the head of a singly linked-list. The list can be represented as:

// [1, 6, 2, 5, 3, 4] => [0, N, 1, N - 1, 2, N - 2, 3, N -3]

/**
    * Definition for singly-linked list.
    * public class ListNode {
    *     int val;
    *     ListNode next;
    *     ListNode() {}
    *     ListNode(int val) { this.val = val; }
    *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
    * }
*/

public class ReorderListSolution {
    public void ReorderList(ListNode head) {
        // [1, 2, 3, 4, 5, 6]
        // [1, 6, 2, 5, 3, 4] => [0, N, 1, N - 1, 2, N - 2, 3, N -3]

        // [1, 2, 3, 4, 5, 6, 7]
        // [1, 7, 2, 6, 3, 5, 4]

        ListNode reordered = head;
        ListNode front = head;
        ListNode back = head;

        ListNode nextPair;
        int backVal;

        while (reordered.next != null)
        {
            Console.WriteLine("Test 2");

            while (back.next != null)
            {
                back = back.next;
            }

            nextPair = reordered.next;
            reordered.next = back;
            reordered.next.next = nextPair;

            while (reordered != null)
            {
                reordered = reordered.next;
            }

            back = reordered;
        }
    }

    // Find the middle of the linked list. 
    // For Example:- 1->2->3->4->5
    // Here, middle = 3;
    // Then reverse the second half of the Linked List (i.e. 4->5), 
    // so after reversing the list will be 5->4
    // Now, merge both list in ordered way like one element of 1st half linkedlist (i.e 1->2->3) and 
    // one element of second half list (i.e 5->4) so after merging the list will become:-
    // 1->5->2->4->3

    // Approach
    // For finding the middle of the linked list we can use slow and fast pointer approach.
    // For reversing the list we can use the Reverse linkedList I approach.
    // Then we can merge list one by one.

    public void ReorderList_3(ListNode head) {
        // if head will be null or head.next will be null simply return
        if (head == null || head.next == null) return;

        //finding middle element
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // reversing the second half of the list
        ListNode newNode = reverseList(slow.next);

        // breaking the list from the middle
        slow.next = null;

        //merging both list
        //first half list pointer
        ListNode curr = head; //1

        //second half list pointer
        ListNode dummy = newNode; //7

        //[7, 2, 6, 5]

        while (head != null && dummy != null)
        {
            // pointer to store next element of curr(1st half list)
            ListNode temp = curr.next; //2, 3, 4

            // link element of 1st half to that of second half
            curr.next = dummy; //7, 6, 5

            // pointer to store next element of dummy(2nd half list)
            ListNode temp2 = dummy.next; //6, 5, null

            // link the rest of the first half list
            dummy.next = temp; //2, 3, 4

            // increment curr and dummy pointer to do the same thing again and 
            // again util we reach end of the any one list or both list
            curr = temp; // 2, 3, 4
            dummy = temp2; // 6, 5, null
        }
        
        // [1, 7, 2]
        // [1, 7, 2, 6, 3, 5, 4]
    }

    // method to reverse the 2nd half of the list
    public ListNode reverseList(ListNode node){ //[5, 6, 7]
        ListNode prev = null; //5
        ListNode curr = node; //5, null
        ListNode next = null; //6

        while (curr != null)
        {
            next = curr.next; //6, 7, null
            curr.next = prev; //null, 5, 6
            prev = curr; //5, 6, 7
            curr = next; //6, 7, null
        }
    
        return prev;
    }
}


// NOTES
// In my attempt, I was instinctively trying to implement the reverse list as we see in the 2nd solution
// tho it took me a hot second to fully understand it, tg for the geeks for geeks video,
// i like the idea of reversing the 2nd half and then merging the two lists
// HOW CREATIVE!!
// then the merge is actually quite similar to the reversal but obviously we're combining 2 lists
// this was a difficult and annoying yet enjoyable journey!!!

// WRITTEN EXPLANATION FOR LIST REVERSAL
// the input is a single node that likely has nodes after it
// that node becomes current and then we have 2 pointers for previous and next
// we start a while loop that stops when current becomes null
// first we store the next of current so taht we dont overwrite it
// then we replace next to be the previous node- which essentially severs the list into 2 parts
// but at first it'll be null bc there is no previous
// so then the last 2 lines of the while loop just advance current and next to the following nodes, respectively
// finally, at the end, current will be null once prev is at the final node of the original list,
// but it's now the head of the reversed list! neat-o!