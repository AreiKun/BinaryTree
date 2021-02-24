using BinaryTreeSearch;
using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BTree btr = new BTree();
            btr.Add(6);
            btr.Add(2);
            btr.Add(3);
            btr.Add(11);
            btr.Add(30);
            btr.Add(9);
            btr.Add(13);
            btr.Add(18);
            btr.Add(27);
            btr.Add(31);
            btr.Print();
        }    
    }
}
