using System;
using System.Collections.Generic;
using System.Text;

namespace BTreeTraining
{
    class Tree<T>
        where T: IComparable
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }

        public void Add(T data)
        {
            var node = new Node<T>(data);

            if(Root == null)
            {
                Root = node;
                Count = 1;
                return;
            }

            var current = Root;

            if( current == null)
            {
                if(node.CompareTo(current) == -1)
                {
                    //if(current.Left = null)
                    {

                    }
                }
            }
        }

    }
}
