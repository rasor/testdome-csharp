using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp1
{
    /// <summary>
    /// https://www.testdome.com/tests/c-sharp-algorithms-online-test/21
    /// </summary>
    public class Node
    {
        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(int value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public bool Contains(int value)
        {
            // Is this the node we look for?
            if (this.Value == value) return true;

            // search left
            if (this.Left != null)
            {
                if (this.Left.Contains(value)) return true;
            }

            // search right
            if (this.Right != null)
            {
                if (this.Right.Contains(value)) return true;
            }

            // not found
            return false;
        }
    }

    public class BinarySearchTree
    {
        public static bool Contains(Node root, int value)
        {
            var retVal = root.Contains(value);
            return retVal;
        }

        public static bool Contains3(Node root, int value)
        {
            // Is this the node we look for?
            if (root.Value == value) return true;

            // Children contains? - exec each side in parallel
            var children = new Node[] { root.Left, root.Right };
            var foundList = children.AsParallel().Where(n => (n != null) && n.Contains(value)).ToArray();

            var retVal = foundList.Length > 0;
            return retVal;
        }
        public static bool Contains2(Node root, int value)
        {
            // Is this the node we look for?
            if (root.Value == value) return true;

            // search left
            if (root.Left != null)
            {
                if (Contains2(root.Left, value)) return true;
            }

            // search right
            if (root.Right != null)
            {
                if (Contains2(root.Right, value)) return true;
            }

            // not found
            return false;
        }

        public static void Main04(string[] args)
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(Contains2(n2, 3));
            sw.Stop();
            Console.WriteLine("Time w. static: {0} ticks", sw.ElapsedTicks);
            // 22 ms - 200k ticks

            sw.Restart();
            Console.WriteLine(Contains(n2, 3));
            sw.Stop();
            Console.WriteLine("Time w. inst.: {0} ticks", sw.ElapsedTicks);
            // 0 ms - 2k ticks

            sw.Restart();
            Console.WriteLine(Contains3(n2, 3));
            sw.Stop();
            Console.WriteLine("time w. inst. and parallel: {0} ticks", sw.ElapsedTicks);

            Console.ReadKey();
        }
    }

}
