using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructures
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        static void p(Node h)
        {
            Node t = h;
            while(t!=null)
            {
                Console.Write("{0}->",t);
            }
            Console.WriteLine();
        }

    }


    class Node {

        public Node next;
        public int val;
        public Node(int Val)
        {
            this.val = Val;
        }
        public override string ToString()
        {
            return this.val+"";
        }
    
    }

    class TNode {

        public TNode left;
        public TNode right;
        public int val;
        public TNode(int t)
        {
            this.val = t;
        }
        public override string ToString()
        {
            return this.val + "";
        }
    }
}
