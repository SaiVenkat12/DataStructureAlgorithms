using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms
{
    public class GenericLinkedList<G>
    {
            public Node<G> head;

            internal void Add(G data)
            {
                Node<G> node = new Node<G>(data);
                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    Node<G> temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                }
                Console.WriteLine(node.data);
            }
            public void Search(G word)
            {
                Node<G> temp = this.head;
                while (temp != null)
                {
                    if (temp.data.Equals(word))
                    {
                        Console.WriteLine("This Word: {0} is found ", temp.data);

                        return;
                    }
                    temp = temp.next;
                }
                if (temp == null)
                {
                    Console.WriteLine("This Word: {0} is not found", word);
                    Add(word);
                }
            }
        public void OrderedSearch(G num)
        {
            Node<G> temp = this.head;
            while (temp != null)
            {
                if (temp.data.Equals(num))
                {
                    Console.WriteLine("This Number: {0} is found ", temp.data);

                    return;
                }
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("This Number: {0} is not found", num);
                Add(num);
            }
        }

        public void Display()
            {
                Node<G> temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("Generic Linked list is empty");
                }
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
    }
}
