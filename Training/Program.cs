using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApplication188
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> root = new Node<int> { Data = 1 };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Tree:");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(root.ToStringTree() + "\r\n");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1 Add Left");
                Console.WriteLine("2 Add Right");
                Console.WriteLine("3 Remove");
                Console.WriteLine("4 Get parent");
                Console.WriteLine("5 Get Left");
                Console.WriteLine("6 Get Right");
                Console.WriteLine("9 Exit");

                Console.ForegroundColor = ConsoleColor.Gray;
                var command = ReadInt();

                if (command == 9) break;

                int data = ReadInt("Enter data of node: ");

                var node = root.GetThisAndAllChilds(d => d == data).FirstOrDefault();
                if (node == null)
                    WriteAndWait("Node is not found");
                else
                    switch (command)
                    {
                        case 1: node.InsertLeft(new Node<int> { Data = ReadInt("Enter data of new child node: ") }); break;
                        case 2: node.InsertRight(new Node<int> { Data = ReadInt("Enter data of new child node: ") }); break;
                        case 3: if (node.Parent != null) node.Parent.DeleteChild(node); break;
                        case 4: if (node.Parent != null) WriteAndWait("Parent: " + node.Parent); break;
                        case 5: if (node.Left != null) WriteAndWait("Left: " + node.Left); break;
                        case 6: if (node.Right != null) WriteAndWait("Right: " + node.Right); break;
                    }
            }
        }

        private static void WriteAndWait(string str)
        {
            Console.WriteLine(str);
            Console.Write("(press any key to continue...)");
            Console.ReadKey();
        }

        static int ReadInt(string title = "")
        {
            if (title != null)
                Console.Write(title);

            int res = 0;

            while (true)
                if (int.TryParse(Console.ReadLine(), out res))
                    return res;
        }
    }

    class Node<T>
    {
        public Node<T> Parent { get; private set; }
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }
        public T Data { get; set; }

        public void InsertRight(Node<T> node)
        {
            node.Right = Right;
            Right = node;
            node.Parent = this;
        }

        public void InsertLeft(Node<T> node)
        {
            node.Left = Left;
            Left = node;
            node.Parent = this;
        }

        public void DeleteChild(Node<T> node)
        {
            if (Right == node) Right = null;
            if (Left == node) Left = null;
            node.Parent = null;
        }

        public IEnumerable<Node<T>> GetThisAndAllChilds(Predicate<T> condition = null)
        {
            if (condition == null || condition(Data))
                yield return this;

            if (Right != null)
                foreach (var n in Right.GetThisAndAllChilds(condition))
                    yield return n;

            if (Left != null)
                foreach (var n in Left.GetThisAndAllChilds(condition))
                    yield return n;
        }

        public override string ToString()
        {
            return Data.ToString();
        }

        public string ToStringTree(int indent = 0)
        {
            var sb = new StringBuilder();
            sb.AppendLine(new String(' ', indent) + ToString());
            if (Right != null)
                sb.Append(Right.ToStringTree(indent + 1));
            if (Left != null)
                sb.Append(Left.ToStringTree(indent + 1));

            return sb.ToString();
        }
    }
}
