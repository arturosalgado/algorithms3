using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedItereative
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n = createList();
            print(n);
            Node b = reverse(n);
            print(b);
            Console.ReadKey();

        }

        static Node  reverse(Node head)
        {
            Node prev = null;
            Node next = null;
            Node curr = null;

            curr = head; 
            while(curr!=null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            head = prev;
            return head;
        }

        static Node createList()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);

            n1.next = n2;
            n2.next = n3;

            return n1;
        }

        static void print(Node h)
        {
            Node t = h;
            while(t!=null){
                Console.Write("{0} -> ",t);
                t = t.next;
            }
            Console.Write("");
        }
    }

    
    class Node{
    
        public Node next; 
        public int Value;

        public Node(int Value)
        {
            this.Value = Value;
        }

        public override string ToString()
        {
            return this.Value + "";
        }
    
    }
}
