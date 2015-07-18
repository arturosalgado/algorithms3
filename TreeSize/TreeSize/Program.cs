using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSize
{
    class Program
    {
        static void Main(string[] args)
        {
            TNode root = createTree();

            Console.WriteLine("size is {0}",size(root));
            Console.WriteLine("size is {0}", size_i(root));

            Console.ReadKey();

        }

        static int size(TNode root)
        {
            if (root == null)
                return 0;
            return 1 + size(root.left) + size(root.right);
        }

        static int size_i(TNode root)
        {
            int count = 0; 
            Queue<TNode> queue = new Queue<TNode>();
            if (root != null) { 
                queue.Enqueue(root);
                count++;
            }
            while (queue.Count > 0)
            {
                TNode t = queue.Dequeue();
                if (t.right != null)
                {
                    count++;
                    queue.Enqueue(t.right);
                }
                if (t.left != null)
                {
                    count++;
                    queue.Enqueue(t.left);
                }
            }

            return count;


        }

        static TNode createTree()
        {

            TNode n1 = new TNode(1);
            TNode n2 = new TNode(2);
            TNode n3 = new TNode(3);
            TNode n4 = new TNode(4);
            TNode n5 = new TNode(5);
            TNode n6 = new TNode(6);
            TNode n7 = new TNode(7);


            n4.left = n2;
            n4.right = n5;

            n2.left = n1;
            n2.right = n3;

            n5.right = n6;

            n6.right = n7;
             ///     n4
             /// n2     n5
            ///n1   n3     n6


            return n4;
        }

    }


    class TNode
    {

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
