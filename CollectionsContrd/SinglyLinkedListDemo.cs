using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsContrd
{
    public class Node
    {
        private string data;
        private Node next = null;
        public string Data
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

    internal class SinglyLinkedList
    {
        private Node root = null;
        private Node current = null;
        private int length;

        public Node Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public void add(Node node)
        {
            node.Next = null;
            if (root == null)
            {
                root = node;
                length = 1;
                current = root;
            }
            else
            {
                current.Next = node;
                current = node;
                length++;
            }
        }

        public Node getCurrent()
        {
            return this.current;
        }

        public Node ShowRoot()
        {
            //current = root;
            return this.root;
        }

        public Node getNext()
        {
            if (current.Next != null)
            {
                current = current.Next;
                return current;
            }
            else
                return null;
        }

        public int getLengthOfList()
        {
            return this.length;
        }
        public void CreateSinglyLinkedList()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            Node n = new Node();
            n.Data = "root";
            list.add(n);
            for (int i = 0; i < 10; i++)
            {
                Node node = new Node();
                node.Data = Convert.ToString(i);
                list.add(node);
            }

            Console.WriteLine("length of singly linked list=" + list.getLengthOfList());

            Console.WriteLine( "Print Single linked list ");
            n = list.ShowRoot();
            while (n != null)
            {
                Console.WriteLine(n.Data);
                
                n = list.getNext();
            }


        }

    }
}                   
