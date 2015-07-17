using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.insert(0);
            l.insert(3);
            l.insert(5);
            //Console.WriteLine(l);

            LinkedList l2 = new LinkedList();
            //l2.insert_sorted(0);
            l2.insert_sorted(3);
            l2.insert_sorted(2);
            l2.insert_sorted(1);
            l2.insert_sorted(4);
            l2.insert_sorted(5);
            l2.insert_sorted(0);
            l2.insert_sorted(10);
            l2.insert_sorted(7);

          
            Console.WriteLine(l2);
            Console.WriteLine("This is the value: {0} is in list ? {1}", 0, l2.find(0));

            Console.WriteLine("remove head (0)");
            

            l2.remove(0);

           

            Console.WriteLine(l2);
            
            Console.ReadKey();
        }
    }

    class LinkedList {

        Node head = null;
        public  bool find(int v)
        {
            Node t = head;
            while (t != null && t.Value != v)
            {
                t = t.Next;
            }
            if (t == null)
                return false;
            else
                return true;

           
        }
        public void insert(int t)
        {
            Node n = new Node(t);
            if (head == null)
            {
                head = n;
            }
            else {
                n.Next = head;
                head = n;
            }
        }


       
        public void insert_sorted(int t)
        {
            Node n = new Node(t);
            if (head == null || n.Value <= head.Value )
            {
                n.Next = head;
                head = n;

            }
            else
            {
                Node q = head;
                
                while (q.Next != null && n.Value > q.Next.Value)
                {
                    q = q.Next;
                }


                if (q.Next == null)
                {

                    q.Next = n;

                }
                else
                {

                    n.Next = q.Next;
                    q.Next = n;


                }

            }
        }

        public void remove(int value)
        {
            if (head.Value == value)
            {
                head = head.Next; /// doesnt matter if the next is null really 
                return;
            }

            Node t = head;
            while (t.Next != null && value != t.Next.Value) {
                t = t.Next;
            }

            if (value == t.Next.Value)
            {
                t.Next = t.Next.Next;
            }

        }
       

        public override string ToString()
        {
            string s="";
            Node t = head;
            while (t != null)
            {
                s += t;
                t = t.Next;
            }
            return s;
        }
    }

    class Node {
        public int Value;
        public Node Next=null; 
        public Node(int Value) {
            this.Value = Value;
        }
        public override string ToString()
        {
            return Convert.ToString(this.Value)+"=> ";
        }
    }

    class CLL {

        Node head = null;

        public void insert(Node t)
        { 
        
        }
    
    
    }
    

}
