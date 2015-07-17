using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList l = new LinkedList();
            l.insert(5, 0);
            l.insert(6, 1);
            l.insert(7, 2);
            l.insert(8, 3);

            Console.Write(l);

            Node loop = l.loop();
            Console.WriteLine("has loop {0}",hasLoop(loop));

            Console.ReadKey();
        }

        static bool hasLoop(Node head)
        {
            Node t = head;
            Node behind = head;

            while (true)
            {
                if (t == null || t.next== null || t.next.next == null)
                    return false;
                if (behind == t.next.next) {
                    return true;
                }
                //if (t!=null)
                behind = t;
                //else return false;
                //if (t.next!=null)
                t = t.next;
                //else return false;

                Console.WriteLine("... ");
            }
            
        }

    }
    class LinkedList {
        Node head;

        public void insert(int val, int pos)
        {
            Node n = new Node(val);
            if (head == null) { 
                head = n;
                return;
            }
            Node t = head;
            int count = 0;
            while (count < pos && t.next !=null)
            {
                t = t.next;
                count++;
            }

            t.next = n;
        }
        public override string ToString()
        {
            string s = "";
            Node t = head;
            while (t != null) {

                s += " "+t.Value;
                t = t.next;
            }
            return s; 
        }

        public Node loop()
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
            n6.next = n1;
            return n1;
        }
    }

    class Node {

        public int Value;
        public Node next;
        public Node(int Val)
        {
            this.Value = Val;

        }
    
    }

}
