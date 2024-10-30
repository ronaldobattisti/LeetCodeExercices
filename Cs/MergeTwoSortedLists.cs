using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    internal class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(/*ListNode list1, ListNode list2*/)
        {
            ListNode head = new ListNode(-1);
            ListNode toReturn = head;

            while (list1 != null || list2 != null)
            {
                if (list1 != null && list2 != null)
                {
                    if (list1.val <= list2.val)
                    {
                        toReturn.next = list1;
                        list1 = list1.next;

                        toReturn = toReturn.next;
                    }
                    else
                    {
                        toReturn.next = list2;
                        list2 = list2.next;

                        toReturn = toReturn.next;
                    }
                }
                else if (list1 != null && list2 == null)
                {
                    toReturn.next = list1;
                    toReturn = toReturn.next;
                    list1 = list1.next;
                }
                else if (list1 == null && list2 != null)
                {
                    toReturn.next = list2;
                    toReturn = toReturn.next;
                    list2 = list2.next;
                }

            }
            return head.next;
            /*LinkedList list = new LinkedList();
            Console.WriteLine($"Is empty? {list.Empty}");
            Console.WriteLine($"Count - {list.Count}");
            Console.ReadLine();
            return null;*/

        }
    }

    class LinkedList
    {
        /* a->b->c->d
         * Constructor:
         * LinkedList() - initialize the private fields
         * 
         * Private Fields:
         * [x] Node head - is a reference to the IRST node in the list
         * [x] int size - The current size of the list
         * 
         * Public PRoperties:
         * [x] Empty - if the list is empty (bool)
         * [x] Count
         * [ ] Indexer - Acess data like an array
         * 
         * Methods:
         * [ ] Add(int index, object o)
         * [ ] Add(object o) - Add in the END
         * [ ] Remove(int index)
         * [ ] Clear()
         * [ ] IndexOf(object o) - get the object index in list, if not return -1
         * [ ] Contains(object o) - bool
         * [ ] Get(int index) - Gets item in the specified index
         */

        private Node head;
        private int count;

        public LinkedList()
        {
            this.head = head;
            this.count = 0;
        }

        public bool Empty
        {
            get { return this.count == 0; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public object Add(int index, object o)
        {
            //lets make sure that the index is above zero
            if (index < 0) {
                throw new ArgumentOutOfRangeException($"Index: {index}");
            }
            //make sure index is under the size
            if (index > count)
            {
                index = count;
            }

            Node current = this.head;

            //If the list is empty or are trying to add in the beggining...
            //HEAD|Node 1|Node 2
            // a  ->  b  ->  c
            //HEAD|Node 1|Node 2|Node 3
            // d  ->  a  ->  b  ->  c
            
            if (this.Empty || index == 0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = new Node(o, current.Next);
            }

            count++;

            return o;
        }

    }

    public class Node
    {
        /*Constructor:
         *[ ] Noce(object data, Node next)
         *
         *Private Fields:
         *object data - contain the data of the node, what we want to store in list
         *Node next: - reference to the next node in the list
         *
         *Public Properties:
         *[ ] Data - get/set the data field
         *[ ] Next - get/set the next field
         */

        private object data;
        private Node next;

        public Node(object data, Node next)
        {
            this.data = data;
            this.next = next;
        }

        public object Data
        {
            get { return this.data; }    
            set { this.data = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }

    
}
