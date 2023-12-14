public class TwoPointerCyclicalLinkedList
{
    public class Node 
    {
        internal int data;
        internal Node next;
        public Node(int d) {
            data = d;
            next = null;
        }
    }

    //memory: O(1)
    //runtime: O(n)
    // Write a method to output true if the linked list has a cycle and false otherwise.
    public static bool CyclicalLinkedList(Node head)
    {
        Node slow = head;
        Node fast = head;
        
        while (slow.next != null && fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            
            if (slow == fast)
            {
                return true;
            }
        }

        return false;
    }

    //NOTES
    //so we want 2 pointers, a slow and fast
    //we want to see if these 2 ever meet at the same node bc if they do, 
    //that means they're going in circles so the linked list is indeed cyclical
    //if we exhaust the list and we don't ever hit that return, then it means there are no cycles!
}