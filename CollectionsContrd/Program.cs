using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsContrd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SinglyLinkedList list = new SinglyLinkedList();
            //list.CreateSinglyLinkedList();

            LinkedList<string> lnkedList = new LinkedList<string>();
         LinkedListNode<string> firstnode   =lnkedList.AddFirst("First Node");
            lnkedList.AddLast("Last Node");
            lnkedList.AddAfter(firstnode, "Second Node");


            Console.ReadLine();
        }
    }
}
