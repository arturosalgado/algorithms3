using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            Node h = createList();
            p(h);
            h = rotate(h,2);
            p(h);
            Console.ReadKey();
        }

        static Node rotate(Node h, int k)
        {
            Node current = h;
            Node newStart = null;
            
            while(k>1)
            {
                current = current.next;
                k--;

            }
            newStart = current.next;
            current.next = null;

            current = newStart;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = h;

            return newStart;


        }

        static Node createList()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);

            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = n6;
            

            return n1;
            
        }
        static void p(Node h)
        {
            Node t = h;
            while (t != null)
            {
                Console.Write("{0}->", t);
                t = t.next;
            }
            Console.WriteLine();
        }
    }
    class Node
    {

        public Node next;
        public int val;
        public Node(int Val)
        {
            this.val = Val;
        }
        public override string ToString()
        {
            return this.val + "";
        }

    }
}
