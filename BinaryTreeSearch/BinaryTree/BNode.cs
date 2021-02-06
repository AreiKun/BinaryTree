using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class BNode<T> where T : IComparable
    {
        public int item;
        public BNode<T> right;
        public BNode<T> left;

        public BNode(int item)
        {
            this.item = item;
        }
    }
}
