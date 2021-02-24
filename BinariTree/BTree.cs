using System;

namespace BinariTree
{
    public class BTree<T> where T : IComparable
    {
        
        private BNode<T> RootNode;
        private int count;

        public BTree()
        {
            RootNode = null;
            count = 0;
        }

        public bool Add(T data)
        {
            RootNode = new BNode<T>(data);
            count++;
            return true;
        }

        public void InsertRight(BNode<T> node, T data)
        {
            node.RightNode = new BNode<T>(data);
            count++;
            
        }

        public void InsertLeft(BNode<T> node, T data)
        {
            node.LeftNode = new BNode<T>(data);
            count++;
        }

    }
}
