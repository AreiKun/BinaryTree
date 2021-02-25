using System;

namespace BinariTree
{
    public class BTree<T> where T : IComparable
    {
        
        private BNode<int> RootNode;
        private int count;        

        public BTree()
        {
            RootNode = null;
            count = 0;
        }

        public bool Add(BNode<int> bNode)
        {
            RootNode = bNode;
            count++;
            return true;
        }

        public BNode<int> Root { get { return RootNode; } }

        public void Print()
        {
            Root.Print();
        }

    }
}
