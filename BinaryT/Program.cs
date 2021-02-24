using System;

namespace BinaryT
{
    class Program
    {
        static void Main(string[] args)
        {
            BTree btr = new BTree();
            var b = new BNode(3);
            btr.Add(6);
            btr.Add(2);
            btr.Add(3);
            btr.Add(2);
            btr.Add(8);
            btr.Print();
        }
    }
}
