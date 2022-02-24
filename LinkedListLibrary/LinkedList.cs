namespace LinkedListLibrary
{
    /// <summary>
    /// Generic representation of a node in a linked list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class Node<T>
    {
        internal T data;
        internal Node<T> next;
        
        /// <summary>
        /// Initializes nodw with data, sets next node to null.
        /// </summary>
        /// <param name="data"></param>
        public Node(T data)
        {
            this.data = data;
            next = null;
        }
    }
    /// <summary>
    /// Generic linked list implementation with copy constructor
    /// and get fifth from last element function.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T>
    {

        internal Node<T> head;

        /// <summary>
        /// Generic linked list.
        /// </summary>
        /// <param name="other">Array of type T to copy into list.</param>
        /// <exception cref="System.NullReferenceException">Thrown when argument is null.</exception>
        public LinkedList(T[] other)
        {
            if(other == null)
            {
                throw new NullReferenceException("List is Null");
            }
            foreach(T item in other)
            {
                InsertLast(item);
            }
        }
       
        /// <summary>
        /// Inserts data at the end of the linked list.
        /// </summary>
        /// <param name="data"></param>
        internal void InsertLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if(head == null)
            {
                head = newNode;
                return;
            }
            Node<T> last = GetLastNode();
            last.next = newNode;
        }
        
        /// <summary>
        /// Retrieves last node in the linked list.
        /// </summary>
        /// <returns>The last node in the list.</returns>
        internal Node<T> GetLastNode()
        {
            Node<T> ptr = head;
            while (ptr.next != null)
            {
                ptr = ptr.next;
            }
            return ptr;
        }

        /// <summary>
        /// Approach: have one pointer traverse 5 nodes if it can,
        /// and another pointer follow behind until the first pointer reaches
        /// the end of the list. Always check to make sure len(list) > 5 with
        /// null checking.
        /// </summary>
        /// <exception cref="System.InvalidOperationException">Thrown when length of list is less than 5.</exception>
        /// <returns>The fifth from the last element in the linked list</returns>
        public T GetFifthLastElement()
        {
            Node<T> lead = head, follow = head;
            int n = 5;
            int count = 0;
            // Traverse n many nodes with lead pointer first

            while(count < n)
            {
                if(lead == null)
                {
                    // There weren't at least n many elements in the list
                    throw new InvalidOperationException("Length of list is less than 5.");
                }
                lead = lead.next;
                count++;
            }

            // increment follow until lead is at the end of the list
            while(lead != null)
            {
                lead = lead.next;
                follow = follow.next;
            }

            return follow.data;
        }

    }
}