using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Node t = tree();

        }

        static Node tree()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);


            n4.left = n2;
            n4.right = n5;

            n2.left = n1;
            n2.right = n3;

            n4.right = n5;
            n5.right = n6;

            return n4;
        
        
        }

    }

    class Node {

        public Node left;
        public Node right;
        public int Value;

        public Node(int Value) {
            this.Value = Value;
        }

        public override string ToString()
        {
            return this.Value + "";
        }
    }
}
