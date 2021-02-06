using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeSearch
{
    public class BNode
    {
        public int item;
        public BNode right;
        public BNode left;

        public BNode(int item)
        {
            this.item = item;
        }
    }
}
