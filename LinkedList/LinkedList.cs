using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private Node<T> head;
        public LinkedList()
        {
            head = null;
        }

        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                //search to the end of node
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void InsertionSort()
        {
            // Check the base case: if the list is empty or contains only one element, sorting is not needed.
            if (head == null || head.Next == null)
                return;

            Node<T> sorted = null;  // Create a new list to which we'll add elements in sorted order.
            Node<T> current = head; // Point to the current element in the original list.

            while (current != null)
            {
                Node<T> next = current.Next; // Remember the next element before modifying current.Next.

                // If sorted is empty or the current element is smaller than the first element in sorted,
                // add the current element to the beginning of sorted.
                if (sorted == null || Comparer<T>.Default.Compare(current.Value, sorted.Value) < 0)
                {
                    current.Next = sorted; // Set the current element's next to the current start of sorted.
                    sorted = current;      // Update the start of sorted.
                }
                else
                {
                    Node<T> search = sorted;

                    // Find the place in sorted after which to insert the current element.
                    // Continue until the end of sorted or until a larger element is found.
                    while (search.Next != null && Comparer<T>.Default.Compare(current.Value, search.Next.Value) >= 0)
                    {
                        search = search.Next; // Move to the next element in sorted.
                    }

                    // Insert the current element after the search element.
                    current.Next = search.Next;
                    search.Next = current;
                }

                // Move to the next element in the original list.
                current = next;
            }

            // Update the head pointer to point to the start of the sorted list.
            head = sorted;
        }

        public List<T> GetValues()
        {
            Node<T> current = head;
            List<T> result = new List<T>();
            while(current != null)
            {
                result.Add(current.Value);
                current = current.Next;
            }
            return result;
        }
    }
}
